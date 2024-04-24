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
            var propretiesObjectTypes = new Dictionary<string, IProperty[]>();
            var propertyManager = PropertiesManagerPlugin.m_app.Project.PropertyManager;
            foreach (var objectType in propretiesObjectTypes.Keys)
            {
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

        }

        private void DeleteClick(object sender, EventArgs e)
        {

        }
    }
}
