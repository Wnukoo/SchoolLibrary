namespace LibraryApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.GroupBox groupBorrow;
        private System.Windows.Forms.TextBox textCopyId;
        private System.Windows.Forms.TextBox textStudentName;
        private System.Windows.Forms.Button buttonBorrow;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupAdd;
        private System.Windows.Forms.TextBox textNewTitle;
        private System.Windows.Forms.TextBox textNewAuthor;
        private System.Windows.Forms.TextBox textNewIsbn;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.groupBorrow = new System.Windows.Forms.GroupBox();
            this.textCopyId = new System.Windows.Forms.TextBox();
            this.textStudentName = new System.Windows.Forms.TextBox();
            this.buttonBorrow = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupAdd = new System.Windows.Forms.GroupBox();
            this.textNewTitle = new System.Windows.Forms.TextBox();
            this.textNewAuthor = new System.Windows.Forms.TextBox();
            this.textNewIsbn = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.groupBorrow.SuspendLayout();
            this.groupAdd.SuspendLayout();
            this.SuspendLayout();

            // dataGridViewBooks
            this.dataGridViewBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBooks.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.Size = new System.Drawing.Size(760, 250);
            this.dataGridViewBooks.TabIndex = 0;

            // groupBorrow
            this.groupBorrow.Controls.Add(this.textCopyId);
            this.groupBorrow.Controls.Add(this.textStudentName);
            this.groupBorrow.Controls.Add(this.buttonBorrow);
            this.groupBorrow.Controls.Add(this.buttonReturn);
            this.groupBorrow.Controls.Add(this.buttonDelete);
            this.groupBorrow.Location = new System.Drawing.Point(12, 270);
            this.groupBorrow.Name = "groupBorrow";
            this.groupBorrow.Size = new System.Drawing.Size(500, 120);
            this.groupBorrow.TabIndex = 1;
            this.groupBorrow.Text = "Borrow / Return / Delete";

            // textCopyId
            this.textCopyId.Location = new System.Drawing.Point(10, 25);
            this.textCopyId.PlaceholderText = "Copy ID (8 char)";
            this.textCopyId.Size = new System.Drawing.Size(140, 23);

            // textStudentName
            this.textStudentName.Location = new System.Drawing.Point(160, 25);
            this.textStudentName.PlaceholderText = "Student name";
            this.textStudentName.Size = new System.Drawing.Size(160, 23);

            // buttonBorrow
            this.buttonBorrow.Location = new System.Drawing.Point(10, 60);
            this.buttonBorrow.Size = new System.Drawing.Size(90, 25);
            this.buttonBorrow.Text = "Borrow";
            this.buttonBorrow.Click += new System.EventHandler(this.buttonBorrow_Click);

            // buttonReturn
            this.buttonReturn.Location = new System.Drawing.Point(110, 60);
            this.buttonReturn.Size = new System.Drawing.Size(90, 25);
            this.buttonReturn.Text = "Return";
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);

            // buttonDelete
            this.buttonDelete.Location = new System.Drawing.Point(210, 60);
            this.buttonDelete.Size = new System.Drawing.Size(90, 25);
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);

            // groupAdd
            this.groupAdd.Controls.Add(this.textNewTitle);
            this.groupAdd.Controls.Add(this.textNewAuthor);
            this.groupAdd.Controls.Add(this.textNewIsbn);
            this.groupAdd.Controls.Add(this.buttonAdd);
            this.groupAdd.Location = new System.Drawing.Point(520, 270);
            this.groupAdd.Name = "groupAdd";
            this.groupAdd.Size = new System.Drawing.Size(252, 120);
            this.groupAdd.TabIndex = 2;
            this.groupAdd.Text = "Add new copy";

            // textNewTitle
            this.textNewTitle.Location = new System.Drawing.Point(10, 22);
            this.textNewTitle.PlaceholderText = "Title";
            this.textNewTitle.Size = new System.Drawing.Size(230, 23);

            // textNewAuthor
            this.textNewAuthor.Location = new System.Drawing.Point(10, 47);
            this.textNewAuthor.PlaceholderText = "Author";
            this.textNewAuthor.Size = new System.Drawing.Size(230, 23);

            // textNewIsbn
            this.textNewIsbn.Location = new System.Drawing.Point(10, 72);
            this.textNewIsbn.PlaceholderText = "ISBN";
            this.textNewIsbn.Size = new System.Drawing.Size(230, 23);

            // buttonAdd
            this.buttonAdd.Location = new System.Drawing.Point(75, 97);
            this.buttonAdd.Size = new System.Drawing.Size(95, 23);
            this.buttonAdd.Text = "Add";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);

            // buttonSave
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.Location = new System.Drawing.Point(12, 400);
            this.buttonSave.Size = new System.Drawing.Size(95, 25);
            this.buttonSave.Text = "Save";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);

            // buttonLoad
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLoad.Location = new System.Drawing.Point(113, 400);
            this.buttonLoad.Size = new System.Drawing.Size(95, 25);
            this.buttonLoad.Text = "Load";
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.groupAdd);
            this.Controls.Add(this.groupBorrow);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Name = "MainForm";
            this.Text = "School Library";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.groupBorrow.ResumeLayout(false);
            this.groupBorrow.PerformLayout();
            this.groupAdd.ResumeLayout(false);
            this.groupAdd.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}