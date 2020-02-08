using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace Xmldoc
{
    class Program
    {
        static void Main(string[] args)
        {
           // firstmethod();

            //  xmlload();
          //   xmlwithlinq();
            loaddisplay();
           // product();
        }

        private static void product()
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmldec1 = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmldec1, root);

            //string.Empty makes cleaner code
            XmlElement element1 = doc.CreateElement(string.Empty, "Products", string.Empty);
            doc.AppendChild(element1);

            XmlElement element2 = doc.CreateElement(string.Empty, "Product", string.Empty);
            XmlElement element3 = doc.CreateElement(string.Empty, "Ptitle", string.Empty);
            XmlText text1 = doc.CreateTextNode("laptop");
            element1.AppendChild(element2);
            element2.AppendChild(element3);
            element3.AppendChild(text1);
            XmlElement element4 = doc.CreateElement(string.Empty, "price", string.Empty);
            XmlText text2 = doc.CreateTextNode("45000");
            element2.AppendChild(element4);
            element4.AppendChild(text2);
            doc.Save(Directory.GetCurrentDirectory() + "Product.xml");
        }

        private static void xmlload()
        {
            XmlDocument Xmldoc = new XmlDocument();
            XmlNodeList xmlnode;
            int i = 0;
            string str = null;
            FileStream fs = new FileStream(@"D:\aleena\31st\Xmldoc\Xmldoc\firstXML.xml", FileMode.Open, FileAccess.Read);
            Xmldoc.Load(fs);
            xmlnode = Xmldoc.GetElementsByTagName("book");
            for (i = 0; i <= xmlnode.Count - 1; i++)
            {
                xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                str = xmlnode[i].ChildNodes.Item(0).InnerText.Trim() + " " + xmlnode[i].ChildNodes.Item(1).InnerText.Trim() + " " + xmlnode[i].ChildNodes.Item(1).InnerText.Trim();
                Console.WriteLine(str);
            }
        }

        private static void loaddisplay()
        {
            StringBuilder result = new StringBuilder();

            //load xml
            XDocument xdoc = XDocument.Load(@"D:\aleena\31st\Xmldoc\Xmldoc\firstXML.xml");

            //run query
            var bks = from bk1 in xdoc.Descendants("book")
                      select new
                      {
                          //Header=bk1.Attribute("name").Value,
                          Children = bk1.Descendants("id"),
                          Child1 = bk1.Descendants("name"),
                          Child2 = bk1.Descendants("price")
                      };

            //loop through results
            foreach (var bk in bks)
            {
                result.Append(bk.Children);
                result.Append(bk.Child1);
                result.Append(bk.Child2);
            };

            Console.WriteLine(result);
        }

           private static void xmlwithlinq()
            {
                XDocument doc = new XDocument(new XElement("items",
                                            new XElement("item",
                                            new XElement("Itemname", "cake"),
                                            new XElement("price", "250")),

                                             new XElement("item",
                                            new XElement("Itemname", "pastery"),
                                            new XElement("price", "250"))));
                doc.Save(Directory.GetCurrentDirectory() + "//XmlItem.xml");
            }

              
               private static void firstmethod()
               {
                   XmlDocument xmld = new XmlDocument();    //it display the entire xml document alon with the tag
                   xmld.Load(@"D:\aleena\31st\Xmldoc\Xmldoc\firstXML.xml");
                   XmlNode currentnode = xmld.DocumentElement.FirstChild;
                   Console.WriteLine(currentnode.OuterXml);
                   XmlNode nextnode = currentnode.NextSibling;
                   Console.WriteLine(nextnode.OuterXml);
                   XmlNode node3 = nextnode.NextSibling;
                   Console.WriteLine(node3.OuterXml);
               }  
    }
}
