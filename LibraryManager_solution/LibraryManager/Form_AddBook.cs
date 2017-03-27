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
    public partial class Form_AddBook : Form
    {
        public string InputId { set; get; }
        public string InputFName { set; get; }
        public string InputLName { set; get; }
        public string InputTitle { set; get; }

        public Form_AddBook()
        {
            InitializeComponent();
        }

        public void Form_AddBook_Load(object sender, EventArgs e)
        {

        }

        public void textBox_inputId_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button_SaveAdded_Click(object sender, EventArgs e)
        {

            InputId = textBox_inputId.Text;
            InputFName = textBox_inputFName.Text;
            InputLName = textBox_inputLName.Text;
            InputTitle = textBox_inputTitle.Text;
            this.Visible = false;
        }

        private void label_LName_Click(object sender, EventArgs e)
        {

        }

        private void label_title_Click(object sender, EventArgs e)
        {

        }

        private void label_Fname_Click(object sender, EventArgs e)
        {

        }
    }
}
