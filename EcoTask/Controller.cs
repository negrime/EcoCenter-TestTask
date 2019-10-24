using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace EcoTask
{
    class Controller
    {
        // Старался использовать этот класс, для каких-то бизнес процессов, чтобы не делать все в View

        // Синглтон
        private static Controller _controller;

        public static Controller GetController()
        {
            if (_controller == null)
            {
                _controller = new Controller();
            }
            return _controller;
        }

        public BookStore OpenXml(string fileName)
        {
            return Serializer.OpenXml(fileName);
        }

        public void SaveXml(BookStore bk, string fileName)
        {
            Serializer.SaveXml(bk, fileName);
        }

        public void XmlToHtml(string xmlFileName, string htmlFileName)
        {
            // Загружаем xslt
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("output.xsl");

            // Переносим из XML в HTML 
            xslt.Transform(xmlFileName, htmlFileName);
        }

        public Book GetParseBook(string linkToBook)
        {
            return BookParser.Parse(linkToBook);
        }

    }
}
