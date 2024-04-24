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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddPropertiesClick(object sender, EventArgs e)
        {
            var rengaObjects = PropertiesManagerPlugin.m_app.Project.Model.GetObjects();
            var temp0 = objectTypes["Аксессуары воздуховода"];
            for (var id = 0; id < rengaObjects.Count; id++)
            {
                var objectModel = rengaObjects.GetById(id);
                if (objectModel == null)
                    continue;
                var name = objectModel.Name;
            }

            var propertyManager = PropertiesManagerPlugin.m_app.Project.PropertyManager;
            for (var id = 0; id < propertyManager.PropertyCount; id++)
            {
                var guid = propertyManager.GetPropertyId(id);
                var propsDesc = propertyManager.GetPropertyDescription(guid);
                var name = propsDesc.Name;
            }
        }

        private void CancelAddingClick(object sender, EventArgs e)
        {

        }

        private void DeleteClick(object sender, EventArgs e)
        {

        }
    }
}
