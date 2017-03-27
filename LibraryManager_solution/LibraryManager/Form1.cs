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
        private Form_AddBook formAddBook;
        private Form_EditItem formEditBook;

        public MainWindow()
        {
            InitializeComponent();
            Path = @"../../Repository.xml";
            LoadXmlDoc();
        }

        private void LoadXmlDoc()
        {
            xmlDoc = new XmlDocument();
            xmlDoc.Load(Path);
            xmlRoot = xmlDoc.DocumentElement;

            ListViewItem item = null;
            CatalogTable.Items.Clear();
            foreach (XmlNode node in xmlRoot)
            {
                foreach (XmlNode xmlChildNode in node)
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
            }
        }

        private void SaveToXmlDoc()
        {
            xmlDoc = new XmlDocument();
            XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);

            XmlNode rootXmlElement = xmlDoc.CreateElement("root");
            xmlDoc.AppendChild(rootXmlElement);

            foreach (ListViewItem item in CatalogTable.Items)
            {
                XmlNode bookXmlElement = xmlDoc.CreateElement("book");
                XmlNode idXmlElement = xmlDoc.CreateElement("id");
                XmlNode fNameXmlElement = xmlDoc.CreateElement("autorFName");
                XmlNode lNameXmlElement = xmlDoc.CreateElement("autorLName");
                XmlNode titleXmlElement = xmlDoc.CreateElement("title");

                int i = 0;
                bookXmlElement.AppendChild(idXmlElement);
                XmlText idXmlText = xmlDoc.CreateTextNode(item.Text);
                idXmlElement.AppendChild(idXmlText);

                bookXmlElement.AppendChild(fNameXmlElement);
                XmlText fNameXmlText = xmlDoc.CreateTextNode(item.SubItems[++i].Text);
                fNameXmlElement.AppendChild(fNameXmlText);

                bookXmlElement.AppendChild(lNameXmlElement);
                XmlText lNameXmlText = xmlDoc.CreateTextNode(item.SubItems[++i].Text);
                lNameXmlElement.AppendChild(lNameXmlText);


                bookXmlElement.AppendChild(titleXmlElement);
                XmlText titleXmlText = xmlDoc.CreateTextNode(item.SubItems[++i].Text);
                titleXmlElement.AppendChild(titleXmlText);

                rootXmlElement.AppendChild(bookXmlElement);
            }
            xmlDoc.Save(Path);
        }

        private void CatalogTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            formAddBook = new Form_AddBook();
            formAddBook.Show();
            formAddBook.VisibleChanged += AddNewItem;
        }

        public void AddNewItem(object sender, EventArgs e)
        {
            Form_AddBook frm = (Form_AddBook)sender;
            if (!frm.Visible)
            {
                ListViewItem item = new ListViewItem(frm.InputId);
                CatalogTable.Items.Add(item);
                item.SubItems.Add(frm.InputFName);
                item.SubItems.Add(frm.InputLName);
                item.SubItems.Add(frm.InputTitle);

                frm.Dispose();
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveToXmlDoc();
        }

        private void ButonDel_Click(object sender, EventArgs e)
        {
            CatalogTable.Items.Remove(CatalogTable.FocusedItem);
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            formEditBook = new Form_EditItem();
            formEditBook.Show();
            int i = 0;
            ListViewItem item = CatalogTable.FocusedItem;
            formEditBook.textBox_inputId.Text = item.Text;
            formEditBook.textBox1.Text = item.SubItems[++i].Text;
            formEditBook.textBox2.Text = item.SubItems[++i].Text;
            formEditBook.textBox3.Text = item.SubItems[++i].Text;
            formEditBook.VisibleChanged += EditItem;

        }

        public void EditItem(object sender, EventArgs e)
        {
            Form_EditItem frm = (Form_EditItem)sender;
            if (!frm.Visible)
            {
                int i = 0;
                CatalogTable.FocusedItem.Text = frm.InputId;
                CatalogTable.FocusedItem.SubItems[++i].Text = frm.InputFName;
                CatalogTable.FocusedItem.SubItems[++i].Text = frm.InputLName;
                CatalogTable.FocusedItem.SubItems[++i].Text = frm.InputTitle;

                frm.Dispose();
            }
        }
    }
}
