using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EcoTask
{
    [Serializable]
    public class Book
    {
        public Book(string title, List<String> author, string category, int year, int price)
        {
            this.Title = title;
            this.Authors = author;
            this.Year = year;
            this.Price = price;
            this.Category = category;
        }

        public Book() { Authors = new List<string>(); }

        [XmlAttribute("category")]
        public string Category { get; set; }
        public string Title { get; set; }

        [XmlArray("authors"), XmlArrayItem(typeof(string), ElementName = "author")]
        public List<string> Authors { get; set; }
        public int Year { get; set; }
        public float Price { get; set; }


    }
}
