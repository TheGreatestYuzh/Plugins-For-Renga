using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Renga;

namespace PluginsForRenga
{
    internal class ObjectTypesHandler
    {
        private static Dictionary<string, Guid> map = new Dictionary<string, Guid>
        {
            { "Аксессуары воздуховода", ObjectTypes.DuctAccessory },

        };

        public Guid this[string russianName] { get => map[russianName]; }
    }
}
