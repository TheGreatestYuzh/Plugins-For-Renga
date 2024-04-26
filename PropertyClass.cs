using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PluginsForRenga
{
    public class PropertyClass
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Id { get; set; }

        public MyClass(string name, string type, int id)
        {
            Name = name;
            Type = type;
            Id = id;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Type: {Type}, Id: {Id}");
        }
    }

}