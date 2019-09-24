using EmployeeReportBL.Model;
using System.IO;
using System.Xml.Serialization;

namespace EmployeeReportBL
{
    public static class Serialization
    {
        public static void Serialize(Settings settings)
        {
            var xmlFormatter = new XmlSerializer(typeof(Settings));

            using (var file = new FileStream("settings.xml", FileMode.Create))
            {
                xmlFormatter.Serialize(file, settings);
            }
        }

        public static Settings Deserialize()
        {
            var xmlFormatter = new XmlSerializer(typeof(Settings));

            var fileName = "settings.xml";

            if (File.Exists(fileName))
            {
                using (var file = new FileStream(fileName, FileMode.OpenOrCreate))
                {
                    return xmlFormatter.Deserialize(file) as Settings;
                }
            }

            return new Settings();
        }
    }
}
