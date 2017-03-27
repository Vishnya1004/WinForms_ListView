using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class Form_EditItem : Form
    {
        public string InputId { set; get; }
        public string InputFName { set; get; }
        public string InputLName { set; get; }
        public string InputTitle { set; get; }

        public Form_EditItem()
        {
            InitializeComponent();
        }

        private void Form_EditItem_Load(object sender, EventArgs e)
        {

        }

        private void textBox_inputId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_id_Click(object sender, EventArgs e)
        {

        }

        private void button_SaveAdded_Click(object sender, EventArgs e)
        {

            InputId = textBox_inputId.Text;
            InputFName = textBox1.Text;
            InputLName = textBox2.Text;
            InputTitle = textBox3.Text;
            this.Visible = false;

        }
    }
}
