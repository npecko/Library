using Microsoft.Data.SqlClient.Server;
using System;
using System.Windows.Forms;

namespace Library
{
    public partial class AuthorForm : Form
    {
        public Author FormAuthor { get; set; }
        public AuthorForm()
        {
            InitializeComponent();
        }

        private void AuthorForm_Load(object sender, EventArgs e)
        {
            if (FormAuthor != null)
            {
                textBoxFirstName.Text = FormAuthor.FirstName;
                textBoxLastName.Text = FormAuthor.LastName;
                textBoxMainGenre.Text = FormAuthor.MainGenre;
                numericUpDownBooks.Value = FormAuthor.BooksWritten;
                labelID.Text = FormAuthor.AuthorID.ToString();
            }
        }

        private void AuthorForm_Closing(object sender, FormClosingEventArgs e)
        {
            if (FormAuthor == null) FormAuthor = new Author();
            FormAuthor.FirstName = textBoxFirstName.Text;
            FormAuthor.LastName = textBoxLastName.Text;
            FormAuthor.MainGenre = textBoxMainGenre.Text;
            FormAuthor.BooksWritten = (int)numericUpDownBooks.Value;
        }
    }
}
