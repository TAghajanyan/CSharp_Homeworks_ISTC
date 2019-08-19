using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace ThirdStage.Serializ_Deserialize_Json_Data
{
    public static class Serialize_XML
    {
        public static string Serialize(Rootobject ob)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlSerializer serializer = new XmlSerializer(ob.GetType());

            using (MemoryStream stream = new MemoryStream())
            {
                serializer.Serialize(stream, ob);
                stream.Position = 0;
                xmlDoc.Load(stream);
                return xmlDoc.InnerXml;
            }
        }
    }
}
