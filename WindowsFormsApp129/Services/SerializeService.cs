using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsApp129.Services
{
    public class SerializeService
    {
        static XmlSerializer serializer;
        public static void ObjSerialize(ISerialize obj, Type type, ISerializeType serializer)
        {
            serializer.Serialize(obj, type);
        }
        public static ISerialize ObjDeserialize(ISerialize obj,Type type, ISerializeType serializer) 
        {
            return serializer.Deserialize(obj, type);
        }



        public static void ObjSerialize<T>(T obj, Type type, string fileName)
        {
            serializer = new XmlSerializer(type);
            using (FileStream fs = new FileStream($"{fileName}.xml", FileMode.Create))
            {
                serializer.Serialize(fs, obj);
            }
        }

        public static object ObjDeserialize(Type type, string fileName)
        {
            serializer = new XmlSerializer(type);

            if (File.Exists($"{fileName}.xml") == false) return null;

            using (FileStream fs = new FileStream($"{fileName}.xml", FileMode.Open))
            {
                return serializer.Deserialize(fs);
            }
        }




    }
}
