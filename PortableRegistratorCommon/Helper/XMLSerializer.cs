using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortableRegistratorCommon.Helper
{
    // https://dotnet-snippets.de/snippet/easy-xml-serializing-and-deserializing/3777
    public static class XMLSerializer
    {
        public static string Serialize<T>(this T baseType)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(T), typeof(T).GetNestedTypes());

            using (StringWriter textWriter = new StringWriter())
            {
                serializer.Serialize(textWriter, baseType);
                return textWriter.ToString();
            }
        }

        public static void Serialize<T>(this T baseType, string filePath)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(T), typeof(T).GetNestedTypes());

            using (FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                serializer.Serialize(stream, baseType);
            }
        }

        public static T Deserialize<T>(string filename)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(T), typeof(T).GetNestedTypes());

            if (!File.Exists(filename))
            {
                string ShortDirectory = (filename.Length > 30) ? (filename.Substring(0, 30) + "...") : (filename);
                throw new FileNotFoundException(string.Format("Directory \"{0}\" not found", ShortDirectory));
            }

            T theclass;

            using (FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                theclass = (T)serializer.Deserialize(stream);
            }

            return theclass;
        }
    }
}
