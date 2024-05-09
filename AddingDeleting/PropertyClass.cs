using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RengaExtensions.AddingDeleting
{
    public class PropertyClass
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Id { get; set; }

        public PropertyClass(string name, string type, string id)
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