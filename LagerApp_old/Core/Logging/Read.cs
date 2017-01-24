using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Windows.Forms;

namespace Core.Logging
{
    public static class Read
    {
        public static void Get(string filePath, ListBox list)
        {
            XmlTextReader xmlReader = new XmlTextReader(filePath);
            while (xmlReader.Read())
            {
                switch (xmlReader.NodeType)
                {
                    case XmlNodeType.Element:
                        list.Items.Add("<" + xmlReader.Name + ">");
                        break;
                    case XmlNodeType.Text:
                        list.Items.Add(xmlReader.Value);
                        break;
                    case XmlNodeType.EndElement:
                        list.Items.Add("");
                        break;
                }
            }
        }
    }
}
