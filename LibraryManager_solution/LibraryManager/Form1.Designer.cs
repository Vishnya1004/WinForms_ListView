namespace LibraryManager
{
    partial class MainWindow
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "01",
            "Joanne",
            "Rowling",
            "Harry Potter"}, -1);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editAndSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CatalogTable = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author_FName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Autor_LName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButonDel = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1540, 49);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(75, 45);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(230, 46);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(230, 46);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(230, 46);
            this.saveAsToolStripMenuItem.Text = "Save as";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem1,
            this.editAndSaveToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(80, 45);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(307, 46);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // editAndSaveToolStripMenuItem
            // 
            this.editAndSaveToolStripMenuItem.Name = "editAndSaveToolStripMenuItem";
            this.editAndSaveToolStripMenuItem.Size = new System.Drawing.Size(307, 46);
            this.editAndSaveToolStripMenuItem.Text = "Edit and save";
            // 
            // CatalogTable
            // 
            this.CatalogTable.AllowColumnReorder = true;
            this.CatalogTable.AutoArrange = false;
            this.CatalogTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Author_FName,
            this.Autor_LName,
            this.Title});
            this.CatalogTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.CatalogTable.FullRowSelect = true;
            this.CatalogTable.GridLines = true;
            this.CatalogTable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CatalogTable.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.CatalogTable.Location = new System.Drawing.Point(0, 49);
            this.CatalogTable.Name = "CatalogTable";
            this.CatalogTable.Size = new System.Drawing.Size(1540, 500);
            this.CatalogTable.TabIndex = 1;
            this.CatalogTable.UseCompatibleStateImageBehavior = false;
            this.CatalogTable.View = System.Windows.Forms.View.Details;
            this.CatalogTable.SelectedIndexChanged += new System.EventHandler(this.CatalogTable_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 33;
            // 
            // Author_FName
            // 
            this.Author_FName.Text = "Author_FName";
            this.Author_FName.Width = 171;
            // 
            // Autor_LName
            // 
            this.Autor_LName.Text = "Autor_LName";
            this.Autor_LName.Width = 164;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 172;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdd.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonAdd.Location = new System.Drawing.Point(0, 549);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Padding = new System.Windows.Forms.Padding(3);
            this.ButtonAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonAdd.Size = new System.Drawing.Size(469, 168);
            this.ButtonAdd.TabIndex = 3;
            this.ButtonAdd.Text = "Add book";
            this.ButtonAdd.UseCompatibleTextRendering = true;
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButonDel
            // 
            this.ButonDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonDel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButonDel.Location = new System.Drawing.Point(469, 549);
            this.ButonDel.Name = "ButonDel";
            this.ButonDel.Padding = new System.Windows.Forms.Padding(3);
            this.ButonDel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButonDel.Size = new System.Drawing.Size(554, 168);
            this.ButonDel.TabIndex = 4;
            this.ButonDel.Text = "Delete book";
            this.ButonDel.UseCompatibleTextRendering = true;
            this.ButonDel.UseVisualStyleBackColor = true;
            this.ButonDel.Click += new System.EventHandler(this.ButonDel_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEdit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonEdit.Location = new System.Drawing.Point(1023, 549);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Padding = new System.Windows.Forms.Padding(3);
            this.ButtonEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonEdit.Size = new System.Drawing.Size(519, 168);
            this.ButtonEdit.TabIndex = 5;
            this.ButtonEdit.Text = "Edit book";
            this.ButtonEdit.UseCompatibleTextRendering = true;
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1540, 717);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButonDel);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.CatalogTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Library";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editAndSaveToolStripMenuItem;
        public System.Windows.Forms.ListView CatalogTable;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Author_FName;
        private System.Windows.Forms.ColumnHeader Autor_LName;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButonDel;
        private System.Windows.Forms.Button ButtonEdit;
    }
}

