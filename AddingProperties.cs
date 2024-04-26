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

namespace PluginsForRenga
{
    public partial class AddingProperties : Form
    {
        private static string[] fileLines;
        private static ObjectTypesHandler objectTypes = new ObjectTypesHandler();

        public AddingProperties()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewFilesClick(object sender, EventArgs e)
        {
            var selectingFileWindow = new OpenFileDialog();
            if (selectingFileWindow.ShowDialog() != DialogResult.OK)
                return;

            var file_path = selectingFileWindow.FileName;
            if (!File.Exists(file_path))
                return;

            label3.Text = file_path;

            var names = new List<string>();
            var typeDatas = new List<string>();
            var ids = new List<string>();
            var objectsTypes = new List<string[]>();

            if (file_path.Substring(file_path.Length - 3) == "csv")
            {
                using (StreamReader sr = new StreamReader(file_path))
                {
                    var datas = sr.ReadLine().Split(',');
                    var (name, type, id) = (datas[0], datas[1], datas[2]);
                    names.Add(name);
                    typeDatas.Add(type);
                    ids.Add(id);
                    objectsTypes.Add(datas[3].Split());
                }
            }
            else if (file_path.Substring(file_path.Length - 4) == "xlsx")
            {
                var wb = new Workbook(file_path);
                var sheet = wb.Worksheets[0];
                var rows = sheet.Cells.MaxDataRow;
                var columns = sheet.Cells.MaxDataColumn;

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
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddPropertiesClick(object sender, EventArgs e)
        {
            var propretiesObjectTypes = new Dictionary<string, IProperty[]>();
            var propertyManager = PropertiesManagerPlugin.m_app.Project.PropertyManager;
            foreach (var objectType in propretiesObjectTypes.Keys)
            {
                if(objectType == "")
                {
                    foreach (var property in propretiesObjectTypes[objectType])
                        if (!propertyManager.IsPropertyRegistered(property.Id))
                            propertyManager.RegisterProperty(
                                property.Id,
                                new PropertyDescription() { Name = property.Name, Type = property.Type });
                    continue;
                }

                var guidObjectType = objectTypes[objectType];
                foreach (var property in propretiesObjectTypes[objectType])
                {
                    if (!propertyManager.IsPropertyRegistered(property.Id))
                        propertyManager.RegisterProperty(
                            property.Id,
                            new PropertyDescription() { Name = property.Name, Type = property.Type });
                    if (!propertyManager.IsPropertyAssignedToType(property.Id, guidObjectType))
                        propertyManager.AssignPropertyToType(property.Id, guidObjectType);
                }
            }
        }

        private void CancelAddingClick(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddingProperties_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
