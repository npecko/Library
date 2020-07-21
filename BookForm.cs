using System;
using System.Windows.Forms;

namespace Library
{
    public partial class BookForm : Form
    {
        public Book FormBook { get; set; }
        public BookForm()
        {
            InitializeComponent();
        }

        public void setAuthor(string author)
        {
            textBoxAuthor.Text = author;
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            if(FormBook != null)
            {
                labelID.Text = FormBook.BookID.ToString();
                textBoxTitle.Text = FormBook.Title;
                textBoxGenre.Text = FormBook.Genre;
                textBoxAuthor.Text = FormBook.Author;
                textBoxPublisher.Text = FormBook.Publisher;
            }
        }

        private void BookForm_Closing(object sender, FormClosingEventArgs e)
        {
            if (FormBook == null) FormBook = new Book();
            FormBook.Title = textBoxTitle.Text;
            FormBook.Genre = textBoxGenre.Text;
            FormBook.Author = textBoxAuthor.Text;
            FormBook.Publisher = textBoxPublisher.Text;
        }
    }
}
