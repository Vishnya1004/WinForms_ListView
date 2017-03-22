using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LibraryManager
{
    public partial class MainWindow : Form
    {
        XmlDocument xmlDoc;
        private XmlElement xmlRoot;
        private string Path { get; }

        public MainWindow()
        {
            InitializeComponent();
            Path = @"../../Repository.xml";
            LoadXmlDoc();
            SaveToXmlDoc();

        }

        private void LoadXmlDoc()
        {
            xmlDoc = new XmlDocument();
            xmlDoc.Load(Path);
            xmlRoot = xmlDoc.DocumentElement;
            //foreach (XmlNode xmlNode in xmlRoot)
            //{
            //xmlNode.ChildNodes
            ListViewItem item = null;
            foreach (XmlNode xmlChildNode in xmlRoot.FirstChild.ChildNodes)
            {
                if (xmlChildNode.Name == "id")
                {
                    item = new ListViewItem(xmlChildNode.InnerText);
                    CatalogTable.Items.Add(item);
                }
                else if (xmlChildNode.Name == "autorFName")
                {
                    item.SubItems.Add(xmlChildNode.InnerText);
                }
                else if (xmlChildNode.Name == "autorLName")
                {
                    item.SubItems.Add(xmlChildNode.InnerText);
                }
                else if (xmlChildNode.Name == "title")
                {
                    item.SubItems.Add(xmlChildNode.InnerText);
                }
            }
            //}
        }

        private void SaveToXmlDoc()
        {
            xmlDoc = new XmlDocument();
            xmlDoc.Load(Path);
            xmlRoot = xmlDoc.DocumentElement;
            XmlElement bookXmlElement = xmlDoc.CreateElement("book");
            XmlElement idXmlElement = xmlDoc.CreateElement("id");
            XmlElement fNameXmlElement = xmlDoc.CreateElement("FName");
            XmlElement lNameXmlElement = xmlDoc.CreateElement("LNAme");
            XmlElement titleXmlElement = xmlDoc.CreateElement("title");
            XmlText idXmlText = null;
            XmlText fNameXmlText = null;
            XmlText lNameXmlText = null;
            XmlText titleXmlText = null;


            foreach (ListViewItem item in CatalogTable.Items)
            {
                int i = 0;
                bookXmlElement.AppendChild(idXmlElement);
                idXmlText = xmlDoc.CreateTextNode(item.Text);
                bookXmlElement.AppendChild(fNameXmlElement);
                fNameXmlText = xmlDoc.CreateTextNode(item.SubItems[i++].Text);
                bookXmlElement.AppendChild(lNameXmlElement);
                lNameXmlText = xmlDoc.CreateTextNode(item.SubItems[i++].Text);
                bookXmlElement.AppendChild(titleXmlElement);
                titleXmlText = xmlDoc.CreateTextNode(item.SubItems[i++].Text);
                xmlRoot.AppendChild(bookXmlElement);

            }
            xmlDoc.Save(Path);


        }

        private void CatalogTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
