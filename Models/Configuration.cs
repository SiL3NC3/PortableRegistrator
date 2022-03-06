using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortableRegistrator.Models
{
    public class Configuration
    {
        // STATICS
        internal static Configuration CreateDefault()
        {
            var config = new Configuration();

            var browser = new AppType("Web-Browser")
            {
                //PropertiesParameter = "-preferences",
                OpenParameters = "-url \"%1\"",
                FileAssociations = new List<string>() { ".htm", ".html", ".shtml", ".xht", ".xhtml", },
                URLAssociations = new List<string>() { "http", "https", "ftp", }
            };

            var mail = new AppType("Mail-Program")
            {
                PropertiesParameter = null,
                OpenParameters = "\"%1\"",
                FileAssociations = new List<string>() { ".xpi", ".eml", ".msg", ".ics", ".mbox" },
                URLAssociations = new List<string>() { "mailto", }
            };

            config.AppTypes.Add(browser);
            config.AppTypes.Add(mail);

            return config;
        }

        // PROPERTIES
        public List<AppType> AppTypes { get; set; }

        // CONSTRUCTOR
        public Configuration()
        {
            AppTypes = new List<AppType>();
        }


    }
}
