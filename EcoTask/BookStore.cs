using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EcoTask
{
    [Serializable]
    [XmlRoot("bookStore")]
    public class BookStore
    {
        [XmlArray("bookList"), XmlArrayItem(typeof(Book), ElementName = "book")]
        public List<Book> list;
        public int Size => list.Count;
        public BookStore()
        {
            list = new List<Book>();
        }

        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }

        public void Add(Book book)
        {
            list.Add(book);
            
        }

        public void RemoveAt(int index = 0)
        {
            list.RemoveAt(index);
        }

        public Book GetElement(int index = 0)
        {
            return list[index];
        }

    }
}
