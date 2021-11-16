using System;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
using System.Drawing;

namespace lw4
{
    public partial class Form1 : Form
    {

        public ApplicationData AppData = new ApplicationData();
        
        public Form1()
        {
            InitializeComponent();
        }
        private void CreateReaderButton_Click(object sender, EventArgs e)
        {
            AppData.Readers.Add(new Reader(ReaderNameTextBox.Text));
            MessageBox.Show($"Читатель {ReaderNameTextBox.Text} сохранён!");
            ReaderNameTextBox.Text = "";
        }

        private void CreateBookButton_Click(object sender, EventArgs e)
        {
            AppData.Books.Add(new Book(BookNameTextBox.Text, AuthorNameTextBox.Text));
            MessageBox.Show($"Книга {BookNameTextBox.Text} сохранена!");
            BookNameTextBox.Text = "";
            AuthorNameTextBox.Text = "";
        }

        private void UpdateDataButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (dt.Columns.Count < 1)
            {
                DataColumn bookNameColumn = new DataColumn("Название книги", typeof(string));
                DataColumn authorNameColumn = new DataColumn("Автор книги", typeof(string));

                dt.Columns.Add(bookNameColumn);
                dt.Columns.Add(authorNameColumn);

            }

            foreach (Book book in AppData.Books)
            {
                dt.Rows.Add(book.Name, book.Author);
            }

            ListOfBooks.DataSource = dt;
            
        }

        private void LibraryCardsUpdateButton_Click(object sender, EventArgs e)
        {
            List<string> dt = new List<string>();

            dt.Add("");

            foreach (Reader reader in AppData.Readers)
            {
                dt.Add(reader.Name);
            }

            ReadersComboBox.DataSource = dt;

            foreach (Control item in LibraryCard.Controls)
            {
                if ((item.GetType() == typeof(ComboBox) && item.Name != "ReadersComboBox") ||
                    (item.GetType() == typeof(Label) && item.Name != "ReaderLabel"))
                {
                    item.Dispose();
                }
            }
        }

        private void ReadersComboBox_SelectionChangeCommited(object sender, EventArgs e)
        {
            string readerName = ReadersComboBox.SelectedItem.ToString();
            Reader selectedReader = null;

            foreach (Reader reader in AppData.Readers)
            {
                if (reader.Name == readerName) {
                    selectedReader = reader;
                    break;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                AppData.Books.Add(new Book($"{i}", $"{i * 2}"));
                selectedReader.Card.Books.Add(new LibraryCardItem(AppData.Books[i], BookStatus.Taken));
            }


            int y = 60;

            foreach (LibraryCardItem card in selectedReader.Card.Books)
            {
                Book book = (Book)card.Book;

                Label label = new Label();
                label.Text = $"{book.Name} ({book.Author})";
                label.Location = new Point(16, y);
                label.AutoSize = true;
                LibraryCard.Controls.Add(label);

                ComboBox combo = new ComboBox();
                combo.DataSource = Enum.GetValues(typeof(BookStatus));
                combo.Location = new Point(label.Width + 30, y);
                combo.Name = "";
                LibraryCard.Controls.Add(combo);
                y += 30;
            }
        }
    }
}
