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
    public partial class DeletingProperties : Form
    {
        private static string[] fileLines;
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

            var file_path = selectingFileWindow.FileName;
            if (!File.Exists(file_path))
                return;

            label3.Text = file_path;

            var wb = new Workbook(file_path);
            var sheet = wb.Worksheets[0];
            var rows = sheet.Cells.MaxDataRow;
            var columns = sheet.Cells.MaxDataColumn;

            var names = new List<string>();
            var typeDatas = new List<string>();
            var ids = new List<string>();
            var objectsTypes = new List<string[]>();

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
            if (MessageBox.Show("Вы точно хотите удалить ВСЕ переданные свойства?", "AHTUNG", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            var propretiesObjectTypes = new Dictionary<string, IProperty[]>();
            var propertyManager = PropertiesManagerPlugin.m_app.Project.PropertyManager;
            foreach (var objectType in propretiesObjectTypes.Keys)
            {
                if (objectType == "")
                {
                    foreach (var property in propretiesObjectTypes[objectType])
                        if (propertyManager.IsPropertyRegistered(property.Id))
                            propertyManager.UnregisterProperty(property.Id);
                    continue;
                }

                var guidObjectType = objectTypes[objectType];
                foreach (var property in propretiesObjectTypes[objectType])
                {
                    if (propertyManager.IsPropertyAssignedToType(property.Id, guidObjectType))
                        propertyManager.UnassignPropertyFromType(property.Id, guidObjectType);
                    if (propertyManager.IsPropertyRegistered(property.Id))
                        propertyManager.UnregisterProperty(property.Id);
                }
            }
        }

        private void CancelAddingClick(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
