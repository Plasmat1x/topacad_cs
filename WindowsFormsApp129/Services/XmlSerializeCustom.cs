using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsApp129.Services
{
    public class XmlSerializeCustom : ISerializeType
    {
        XmlSerializer serializer;

        public void Serialize(ISerialize obj, Type type)
        {
            serializer = new XmlSerializer(type);
            using (FileStream fs = new FileStream($"{obj.FileName}.xml", FileMode.Create))
            {
                serializer.Serialize(fs, obj);
            }
        }

        public ISerialize Deserialize(ISerialize obj, Type type)
        {
            serializer = new XmlSerializer(type);

            if (File.Exists($"{obj.FileName}.xml") == false) return null;

            using (FileStream fs = new FileStream($"{obj.FileName}.xml", FileMode.Open))
            {
                return (ISerialize)serializer.Deserialize(fs);
            }
        }
    }
}
