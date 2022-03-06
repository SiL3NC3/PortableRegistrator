using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortableRegistrator.Models
{
    public class AppType
    {
        // PROPERTIES
        public string Name { get; set; }
        public string OpenParameters { get; set; }
        public string PropertiesParameter { get; set; }
        public List<string> FileAssociations { get; set; }
        public List<string> URLAssociations { get; set; }

        // COSTRUCTORS
        public AppType()
        {
            FileAssociations = new List<string>();
            URLAssociations = new List<string>();
        }
        public AppType(string name)
        {
            Name = name;
            FileAssociations = new List<string>();
            URLAssociations = new List<string>();
        }

        // METHODS
        public string GetFileAssociations() { return string.Join(", ", FileAssociations); }
        public string GetURLAssociations() { return string.Join(", ", URLAssociations); }
        public override string ToString()
        {
            return Name;
        }
    }
}
