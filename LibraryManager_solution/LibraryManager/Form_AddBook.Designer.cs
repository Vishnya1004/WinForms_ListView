namespace LibraryManager
{
    partial class Form_AddBook
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
            this.textBox_inputId = new System.Windows.Forms.TextBox();
            this.textBox_inputTitle = new System.Windows.Forms.TextBox();
            this.textBox_inputLName = new System.Windows.Forms.TextBox();
            this.textBox_inputFName = new System.Windows.Forms.TextBox();
            this.label_title = new System.Windows.Forms.Label();
            this.label_LName = new System.Windows.Forms.Label();
            this.label_Fname = new System.Windows.Forms.Label();
            this.button_SaveAdded = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(12, 82);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(42, 32);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "ID";
            // 
            // textBox_inputId
            // 
            this.textBox_inputId.Location = new System.Drawing.Point(224, 76);
            this.textBox_inputId.Name = "textBox_inputId";
            this.textBox_inputId.Size = new System.Drawing.Size(451, 38);
            this.textBox_inputId.TabIndex = 1;
            this.textBox_inputId.TextChanged += new System.EventHandler(this.textBox_inputId_TextChanged);
            // 
            // textBox_inputTitle
            // 
            this.textBox_inputTitle.Location = new System.Drawing.Point(224, 299);
            this.textBox_inputTitle.Name = "textBox_inputTitle";
            this.textBox_inputTitle.Size = new System.Drawing.Size(451, 38);
            this.textBox_inputTitle.TabIndex = 2;
            this.textBox_inputTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_inputLName
            // 
            this.textBox_inputLName.Location = new System.Drawing.Point(224, 220);
            this.textBox_inputLName.Name = "textBox_inputLName";
            this.textBox_inputLName.Size = new System.Drawing.Size(451, 38);
            this.textBox_inputLName.TabIndex = 3;
            this.textBox_inputLName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_inputFName
            // 
            this.textBox_inputFName.Location = new System.Drawing.Point(224, 147);
            this.textBox_inputFName.Name = "textBox_inputFName";
            this.textBox_inputFName.Size = new System.Drawing.Size(451, 38);
            this.textBox_inputFName.TabIndex = 4;
            this.textBox_inputFName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(22, 305);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(70, 32);
            this.label_title.TabIndex = 5;
            this.label_title.Text = "Title";
            this.label_title.Click += new System.EventHandler(this.label_title_Click);
            // 
            // label_LName
            // 
            this.label_LName.AutoSize = true;
            this.label_LName.Location = new System.Drawing.Point(12, 226);
            this.label_LName.Name = "label_LName";
            this.label_LName.Size = new System.Drawing.Size(106, 32);
            this.label_LName.TabIndex = 6;
            this.label_LName.Text = "LName";
            this.label_LName.Click += new System.EventHandler(this.label_LName_Click);
            // 
            // label_Fname
            // 
            this.label_Fname.AutoSize = true;
            this.label_Fname.Location = new System.Drawing.Point(11, 153);
            this.label_Fname.Name = "label_Fname";
            this.label_Fname.Size = new System.Drawing.Size(107, 32);
            this.label_Fname.TabIndex = 7;
            this.label_Fname.Text = "FName";
            this.label_Fname.Click += new System.EventHandler(this.label_Fname_Click);
            // 
            // button_SaveAdded
            // 
            this.button_SaveAdded.Location = new System.Drawing.Point(262, 385);
            this.button_SaveAdded.Name = "button_SaveAdded";
            this.button_SaveAdded.Size = new System.Drawing.Size(344, 89);
            this.button_SaveAdded.TabIndex = 8;
            this.button_SaveAdded.Text = "Save";
            this.button_SaveAdded.UseVisualStyleBackColor = true;
            this.button_SaveAdded.Click += new System.EventHandler(this.button_SaveAdded_Click);
            // 
            // Form_AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 525);
            this.Controls.Add(this.button_SaveAdded);
            this.Controls.Add(this.label_Fname);
            this.Controls.Add(this.label_LName);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.textBox_inputFName);
            this.Controls.Add(this.textBox_inputLName);
            this.Controls.Add(this.textBox_inputTitle);
            this.Controls.Add(this.textBox_inputId);
            this.Controls.Add(this.label_id);
            this.Name = "Form_AddBook";
            this.Text = "Form_AddBook";
            this.Load += new System.EventHandler(this.Form_AddBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        public System.Windows.Forms.TextBox textBox_inputId;
        public System.Windows.Forms.TextBox textBox_inputTitle;
        public System.Windows.Forms.TextBox textBox_inputLName;
        public System.Windows.Forms.TextBox textBox_inputFName;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_LName;
        private System.Windows.Forms.Label label_Fname;
        private System.Windows.Forms.Button button_SaveAdded;
    }
}