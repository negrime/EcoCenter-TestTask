using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EcoTask
{
    class BookParser
    {
        public static Book Parse(string link)
        {

            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(link); // скачиваем html сайта
            Book book = new Book();

            // Парсим 
            book.Title = doc.DocumentNode.SelectSingleNode("//div[@class=\"prodtitle\"]/h1").InnerText;
            book.Authors.Add(doc.DocumentNode.SelectSingleNode("//div[@class=\"authors\"]/a").InnerText);
            var year = doc.DocumentNode.SelectSingleNode("//div[@class=\"publisher\"]").InnerText;
            book.Year = Int32.Parse(Regex.Match(year, @"\d+").Value);

            // Цена может быть по скидке, поэтому разные запросы
            if (doc.DocumentNode.SelectSingleNode("//span[@class=\"buying-price-val-number\"]") != null)
            {
                book.Price = Int32.Parse(doc.DocumentNode.SelectSingleNode("//span[@class=\"buying-price-val-number\"]").InnerText);
            }
            else
            {
                book.Price = Int32.Parse(doc.DocumentNode.SelectSingleNode("//span[@class=\"buying-pricenew-val-number\"]").InnerText);
            }


            var category = doc.DocumentNode.SelectNodes("//a[@rel=\"nofollow\"]/span[@itemprop=\"title\"]");
            book.Category = category[category.Count - 1].InnerText;

            return book;

        }
    }
}
    

