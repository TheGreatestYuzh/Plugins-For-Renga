using Renga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginsForRenga
{
    public class PropertyTypesHandler
    {
        public static Dictionary<string, PropertyType> Map = new Dictionary<string, PropertyType>
        {
            { "Действительное число", PropertyType.PropertyType_Double },
            { "Строка", PropertyType.PropertyType_String },
            { "Угол", PropertyType.PropertyType_Angle },
            { "Площадь", PropertyType.PropertyType_Area },
            { "Булевый", PropertyType.PropertyType_Boolean },
            { "Перечисление", PropertyType.PropertyType_Enumeration },
            { "Целое число", PropertyType.PropertyType_Integer },
            { "Длина", PropertyType.PropertyType_Length },
            { "Логический", PropertyType.PropertyType_Logical },
            { "Масса", PropertyType.PropertyType_Mass },
            { "Объём", PropertyType.PropertyType_Volume }
        };
        public static Dictionary<PropertyType, string> MapInverse = new Dictionary<PropertyType, string>
        {
            { PropertyType.PropertyType_Double, "Действительное число"},
            { PropertyType.PropertyType_String, "Строка" },
            { PropertyType.PropertyType_Angle, "Угол" },
            { PropertyType.PropertyType_Area, "Площадь" },
            { PropertyType.PropertyType_Boolean, "Булевый" },
            { PropertyType.PropertyType_Enumeration, "Перечисление" },
            { PropertyType.PropertyType_Integer, "Целое число" },
            { PropertyType.PropertyType_Length, "Длина" },
            { PropertyType.PropertyType_Logical, "Логический" },
            { PropertyType.PropertyType_Mass, "Масса" },
            { PropertyType.PropertyType_Volume, "Объём" }
        };

        public PropertyType this[string russkoeImya] { get => Map[russkoeImya]; }
    }
}
