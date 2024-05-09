using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renga;
using Newtonsoft.Json;

namespace RengaExtensions.Exporting
{
    public class PropertiesManagerPlugin : IPlugin
    {
        internal static Renga.Application m_app;
        private List<Renga.ActionEventSource> m_eventSources = new List<Renga.ActionEventSource>();

        public bool Initialize(string pluginFolder)
        {
            m_app = new Renga.Application();
            var ui = m_app.UI;
            var panelExtension = ui.CreateUIPanelExtension();

            ui.AddExportAction(
              ExportPropertiesAsJSONAction(ui, "Экспортировать свойства в формате JSON"));

            ui.AddExtensionToPrimaryPanel(panelExtension);
            ui.AddExtensionToActionsPanel(panelExtension, Renga.ViewType.ViewType_View3D);

            return true;
        }

        public void Stop()
        {
            foreach (var eventSource in m_eventSources)
                eventSource.Dispose();

            m_eventSources.Clear();
        }

        private Renga.IAction ExportPropertiesAsJSONAction(Renga.IUI ui, string displayName)
        {
            var action = ui.CreateAction();
            action.DisplayName = displayName;
            var events = new Renga.ActionEventSource(action);

            events.Triggered += (s, e) =>
            {
                var formattedProperties = PropertiesJSONFormatHandler.GetFormattedProperties();
                var serializedProperties = JsonConvert.SerializeObject(formattedProperties, Formatting.Indented);
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                    DefaultExt = "json",
                    AddExtension = true,
                    FileName = "properties.json"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, serializedProperties);
                    MessageBox.Show("Файл успешно сохранен!");
                }
            };

            m_eventSources.Add(events);
            return action;
        }
    }
}