using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EcoTask
{
    class Serializer
    {
        public static void SaveXml(BookStore bk, string fileName)
        {
            // передаем в конструктор тип класса
            XmlSerializer writer = new XmlSerializer(typeof(BookStore));

            // получаем поток, куда будем записывать сериализованный объект
            FileStream sw = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
            StreamWriter file = new StreamWriter(sw);
            writer.Serialize(file, bk);
            file.Close();
        }

        public static BookStore OpenXml(string fileName)
        {
            XmlSerializer xf = new XmlSerializer(typeof(BookStore));
            BookStore tmp;
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                tmp = (BookStore)xf.Deserialize(fs);
            }
            return tmp;
        }
    }
}
