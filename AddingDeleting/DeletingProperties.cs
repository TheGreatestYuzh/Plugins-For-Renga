using Renga;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Cells;

namespace RengaExtensions.AddingDeleting
{
    public partial class DeletingProperties : Form
    {
        private static Dictionary<string, List<PropertyClass>> propertiesObjectTypes;
        private static ObjectTypesHandler objectTypes = new ObjectTypesHandler();

        public DeletingProperties()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ViewFilesClick(object sender, EventArgs e)
        {
            var selectingFileWindow = new OpenFileDialog();
            if (selectingFileWindow.ShowDialog() != DialogResult.OK)
                return;

            var filePath = selectingFileWindow.FileName;
            var fileExtension = Path.GetExtension(filePath);
            if (fileExtension != ".csv" && fileExtension != ".xlsx")
            {
                MessageBox.Show("Неизвестный тип файла. Возомжные типы: .csv, .xlsx", "AHTUNG");
                return;
            }

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Такого файла не существует", "AHTUNG");
                return;
            }
            label3.Text = filePath;

            var names = new List<string>();
            var typeDatas = new List<string>();
            var ids = new List<string>();
            var objectsTypes = new List<string[]>();

            if (fileExtension == ".csv")
            {
                using (var sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        var tempData = line.Split('"');
                        var (firstBlock, types, secondBlock) = (tempData[0], tempData[1], tempData[2]);
                        var datas = firstBlock.Split(',');
                        if (datas.Length != 4)
                        {
                            MessageBox.Show("Неверный формат входных данных", "AHTUNG");
                            return;
                        }

                        var (name, type, id) = (datas[0], datas[1], datas[2]);
                        names.Add(name);
                        typeDatas.Add(type);
                        ids.Add(id);
                        objectsTypes.Add(types.Split(new string[] { ", " }, System.StringSplitOptions.None));
                    }
                }
            }
            else if (fileExtension == ".xlsx")
            {
                var wb = new Workbook(filePath);
                var sheet = wb.Worksheets[0];
                var rows = sheet.Cells.MaxDataRow;
                var columns = sheet.Cells.MaxDataColumn;
                if (columns != 3)
                {
                    MessageBox.Show("Неверный формат входных данных", "AHTUNG");
                    return;
                }

                for (var i = 0; i <= rows; i++)
                {
                    for (var j = 0; j <= columns; j++)
                    {
                        if (j == 0)
                            names.Add((string)sheet.Cells[i, j].Value);
                        else if (j == 1)
                            typeDatas.Add((string)sheet.Cells[i, j].Value);
                        else if (j == 2)
                            ids.Add((string)sheet.Cells[i, j].Value);
                        else if (j == 3)
                            objectsTypes.Add(((string)sheet.Cells[i, j].Value).Split(','));
                    }
                }
            }

            propertiesObjectTypes = new Dictionary<string, List<PropertyClass>>();    //Create a Dictionary
            for (var i = 0; i < names.Count; i++)
            {
                var prop = new PropertyClass(names[i], typeDatas[i], ids[i]);   //Property view as a class
                var objTypes = objectsTypes[i];
                foreach (var objType in objTypes)                              //Adding property to all their ObjectTypes
                {
                    if (!propertiesObjectTypes.ContainsKey(objType))
                        propertiesObjectTypes.Add(objType, new List<PropertyClass>());
                    propertiesObjectTypes[objType].Add(prop);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DeletePropertiesClick(object sender, EventArgs e)
        {
            if (propertiesObjectTypes == null)
            {
                MessageBox.Show("Файл не выбран", "AHTUNG");
                return;
            }
            if (MessageBox.Show("Вы точно хотите удалить ВСЕ переданные свойства?", "AHTUNG", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            var propertyManager = PropertiesManagerPlugin.m_app.Project.PropertyManager;
            var unknowObjectTypes = new List<string>();
            var unknowProperties = new List<string>();
            foreach (var objectType in propertiesObjectTypes.Keys)
            {
                if (!ObjectTypesHandler.Map.ContainsKey(objectType))
                {
                    unknowObjectTypes.Add(objectType);
                    continue;
                }

                if (objectType == "")
                {
                    foreach (var property in propertiesObjectTypes[objectType])
                    {
                        try
                        {
                            var propertyId = new Guid(property.Id);
                            if (propertyManager.IsPropertyRegistered(propertyId))
                                propertyManager.UnregisterProperty(propertyId);
                        }
                        catch
                        {
                            unknowProperties.Add(property.Name);
                        }
                    }
                    continue;
                }

                var guidObjectType = objectTypes[objectType];
                foreach (var property in propertiesObjectTypes[objectType])
                {
                    try
                    {
                        var propertyId = Guid.Parse(property.Id);
                        if (propertyManager.IsPropertyAssignedToType(propertyId, guidObjectType))
                            propertyManager.UnassignPropertyFromType(propertyId, guidObjectType);
                        if (propertyManager.IsPropertyRegistered(propertyId))
                            propertyManager.UnregisterProperty(propertyId);
                    }
                    catch
                    {
                        unknowProperties.Add(property.Name);
                    }
                }
            }
            if (unknowObjectTypes.Count > 0)
                FlexibleMessageBox.Show("Данные типы объектов не существуют, поэтому не добавлены:\n" +
                    string.Join(",\n", unknowObjectTypes), "AHTUNG");
            if (unknowProperties.Count > 0)
                FlexibleMessageBox.Show("Данные свойства имеют невалидный guid, поэтому не добавлены:\n" +
                    string.Join(",\n", unknowProperties), "AHTUNG");

            MessageBox.Show("Свойства успешно удалены!", "Завершение");
            this.Dispose();
        }

        private void CancelAddingClick(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
