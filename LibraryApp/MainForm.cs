using System;
using System.Linq;
using System.Windows.Forms;
using LibraryCore;

namespace LibraryApp
{
    public partial class MainForm : Form
    {
        private readonly Library _library = new();

        public MainForm()
        {
            InitializeComponent();
            InitializeGrid();
            LoadSampleData();
        }

        private void InitializeGrid()
        {
            dataGridViewBooks.AutoGenerateColumns = false;
            dataGridViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewBooks.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Copy ID", DataPropertyName = "CopyId" });
            dataGridViewBooks.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Title", DataPropertyName = "Title" });
            dataGridViewBooks.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Author", DataPropertyName = "Author" });
            dataGridViewBooks.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ISBN", DataPropertyName = "Isbn" });
            dataGridViewBooks.Columns.Add(new DataGridViewCheckBoxColumn { HeaderText = "Borrowed", DataPropertyName = "IsBorrowed" });
            dataGridViewBooks.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Borrower", DataPropertyName = "BorrowerName" });
        }

        private void LoadSampleData()
        {
            _library.AddNewCopy("Wiedźmin", "Andrzej Sapkowski", "978-83-89011-67-4");
            _library.AddNewCopy("Pan Tadeusz", "Adam Mickiewicz", "978-83-240-3100-5");
            RefreshGrid();
        }

        private void RefreshGrid() => dataGridViewBooks.DataSource = _library.Copies.ToList();

        #region Borrow / Return / Delete
        private void buttonBorrow_Click(object? sender, EventArgs e)
        {
            var id = textCopyId.Text.Trim().ToUpper();
            var name = textStudentName.Text.Trim();
            if (id.Length != 8)
            {
                MessageBox.Show("Podaj poprawny 8‑znakowy Copy ID.");
                return;
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Wprowadź imię i nazwisko wypożyczającego.");
                return;
            }
            try
            {
                _library.Borrow(id, new LibraryCard(name));
                RefreshGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void buttonReturn_Click(object? sender, EventArgs e)
        {
            var id = textCopyId.Text.Trim().ToUpper();
            try { _library.Return(id); RefreshGrid(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void buttonDelete_Click(object? sender, EventArgs e)
        {
            var id = textCopyId.Text.Trim().ToUpper();
            if (_library.RemoveCopy(id)) RefreshGrid();
            else MessageBox.Show("Nie znaleziono kopii.");
        }
        #endregion

        #region Add
        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNewTitle.Text) || string.IsNullOrWhiteSpace(textNewAuthor.Text) || string.IsNullOrWhiteSpace(textNewIsbn.Text))
            {
                MessageBox.Show("Wypełnij tytuł, autora i ISBN.");
                return;
            }
            var copy = _library.AddNewCopy(textNewTitle.Text, textNewAuthor.Text, textNewIsbn.Text);
            MessageBox.Show($"Dodano kopię {copy.CopyId}");
            RefreshGrid();
        }
        #endregion

        #region Save / Load
        private void buttonSave_Click(object? sender, EventArgs e)
        {
            using var sfd = new SaveFileDialog { Filter = "JSON files (*.json)|*.json" };
            if (sfd.ShowDialog() == DialogResult.OK) _library.Save(sfd.FileName);
        }

        private void buttonLoad_Click(object? sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog { Filter = "JSON files (*.json)|*.json" };
            if (ofd.ShowDialog() == DialogResult.OK) { _library.Load(ofd.FileName); RefreshGrid(); }
        }
        #endregion
    }
}
