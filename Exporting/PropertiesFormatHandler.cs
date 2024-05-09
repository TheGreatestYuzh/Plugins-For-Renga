using Renga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RengaExtensions.Exporting
{
    public static class PropertiesJSONFormatHandler
    {
        public static Dictionary<string, List<Dictionary<string, string>>> GetFormattedProperties()
        {
            var formattedProperties = new Dictionary<string, List<Dictionary<string, string>>>();
            var propertyManager = PropertiesManagerPlugin.m_app.Project.PropertyManager;
            foreach (var objectType in ObjectTypesHandler.Map)
            {
                var objectTypeProperties = new List<Dictionary<string, string>>();
                for (var index = 0; index < propertyManager.PropertyCount; index++)
                {
                    var propertyId = propertyManager.GetPropertyId(index);
                    var propertyType = propertyManager.GetPropertyType(propertyId);
                    if (propertyManager.IsPropertyAssignedToType(propertyId, objectType.Value))
                        objectTypeProperties.Add(new Dictionary<string, string>
                        {
                            { "Имя", propertyManager.GetPropertyName(propertyId) },
                            { "Тип данных", PropertyTypesHandler.MapInverse[propertyType] },
                            { "Уникальный идентификатор", propertyId.ToString() }
                        });
                }
                formattedProperties.Add(objectType.Key, objectTypeProperties);
            }
            return formattedProperties;
        }
    }
}
