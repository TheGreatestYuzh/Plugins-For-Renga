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

            fileLines = File.ReadAllLines(file_path);
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
