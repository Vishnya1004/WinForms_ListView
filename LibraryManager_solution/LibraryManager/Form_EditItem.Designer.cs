namespace LibraryManager
{
    partial class Form_EditItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_id = new System.Windows.Forms.Label();
            this.label_Fname = new System.Windows.Forms.Label();
            this.label_LName = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.textBox_inputId = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button_SaveAdded = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(12, 74);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(42, 32);
            this.label_id.TabIndex = 1;
            this.label_id.Text = "ID";
            this.label_id.Click += new System.EventHandler(this.label_id_Click);
            // 
            // label_Fname
            // 
            this.label_Fname.AutoSize = true;
            this.label_Fname.Location = new System.Drawing.Point(12, 157);
            this.label_Fname.Name = "label_Fname";
            this.label_Fname.Size = new System.Drawing.Size(107, 32);
            this.label_Fname.TabIndex = 8;
            this.label_Fname.Text = "FName";
            // 
            // label_LName
            // 
            this.label_LName.AutoSize = true;
            this.label_LName.Location = new System.Drawing.Point(13, 248);
            this.label_LName.Name = "label_LName";
            this.label_LName.Size = new System.Drawing.Size(106, 32);
            this.label_LName.TabIndex = 9;
            this.label_LName.Text = "LName";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(12, 331);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(70, 32);
            this.label_title.TabIndex = 10;
            this.label_title.Text = "Title";
            // 
            // textBox_inputId
            // 
            this.textBox_inputId.Location = new System.Drawing.Point(152, 68);
            this.textBox_inputId.Name = "textBox_inputId";
            this.textBox_inputId.Size = new System.Drawing.Size(451, 38);
            this.textBox_inputId.TabIndex = 11;
            this.textBox_inputId.TextChanged += new System.EventHandler(this.textBox_inputId_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(451, 38);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 242);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(451, 38);
            this.textBox2.TabIndex = 13;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(152, 325);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(451, 38);
            this.textBox3.TabIndex = 14;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button_SaveAdded
            // 
            this.button_SaveAdded.Location = new System.Drawing.Point(210, 399);
            this.button_SaveAdded.Name = "button_SaveAdded";
            this.button_SaveAdded.Size = new System.Drawing.Size(344, 89);
            this.button_SaveAdded.TabIndex = 15;
            this.button_SaveAdded.Text = "Save";
            this.button_SaveAdded.UseVisualStyleBackColor = true;
            this.button_SaveAdded.Click += new System.EventHandler(this.button_SaveAdded_Click);
            // 
            // Form_EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 562);
            this.Controls.Add(this.button_SaveAdded);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox_inputId);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label_LName);
            this.Controls.Add(this.label_Fname);
            this.Controls.Add(this.label_id);
            this.Name = "Form_EditItem";
            this.Text = "Form_EditItem";
            this.Load += new System.EventHandler(this.Form_EditItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_Fname;
        private System.Windows.Forms.Label label_LName;
        private System.Windows.Forms.Label label_title;
        public System.Windows.Forms.TextBox textBox_inputId;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button_SaveAdded;
    }
}