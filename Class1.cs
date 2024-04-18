using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renga;

namespace PluginsForRenga
{
    public class PropertiesManagerPlugin: IPlugin
    {
        public static Application m_app;
        private List<Renga.ActionEventSource> m_eventSources = new List<Renga.ActionEventSource>();

        public bool Initialize(string pluginFolder)
        {
            m_app = new Renga.Application();
            var ui = m_app.UI;
            var panelExtension = ui.CreateUIPanelExtension();

            panelExtension.AddToolButton(
              CreateAction(ui, "Синхронизировать свойства"));

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

        private Renga.IAction CreateAction(Renga.IUI ui, string displayName)
        {
            var action = ui.CreateAction();
            action.DisplayName = displayName;
            var events = new Renga.ActionEventSource(action);
            events.Triggered += (s, e) =>
            {
                var addingWindow = new AddingProperties();
                System.Windows.Forms.Application.Run(addingWindow);
                addingWindow.Close();
            };

            m_eventSources.Add(events);
            return action;
        }
    }
}