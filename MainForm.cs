using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Library
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadBooks()
        {
            using (LibraryContext context = new LibraryContext())
            {
                dataGridViewBooks.DataSource = context.Books.Select(b => new { b.BookID, b.Title, b.Author, b.Genre, b.Publisher }).ToList();
            }
        }

        private void LoadAuthors()
        {
            using (LibraryContext context = new LibraryContext())
            {
                dataGridViewAuthors.DataSource = context.Authors.Select(a => new 
                { 
                    a.AuthorID, 
                    a.FirstName, 
                    a.LastName, 
                    a.MainGenre, 
                    a.BooksWritten 
                }).ToList();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadAuthors();
        }

        private void LoadSimilar(string genre)
        {
            using (LibraryContext context = new LibraryContext())
            {
                dataGridViewSimilar.DataSource = context.Books.Where(x => x.Genre == genre).Select(b => new
                {
                    b.BookID,
                    b.Title,
                    b.Author,
                    b.Genre,
                    b.Publisher,
                }).ToList();
            }
        }

        private void LoadOther(int authorID)
        {
            using (LibraryContext context = new LibraryContext())
            {
                dataGridViewOther.DataSource = context.Relations.Where(x => x.AuthorID == authorID).Include(z => z.Book).Select(b => new
                {
                    b.BookID,
                    b.Book.Title,
                    b.Book.Genre,
                    b.Book.Publisher,
                }).ToList();
            }
        }

        private void dataGridViewBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count > 0)
            {
                string genre = (string)dataGridViewBooks.SelectedRows[0].Cells["Genre"].Value;
                LoadSimilar(genre);
            }
        }
        private void dataGridViewAuthors_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewAuthors.SelectedRows.Count > 0)
            {
                int authorID = (int)dataGridViewAuthors.SelectedRows[0].Cells["AuthorID"].Value;
                LoadOther(authorID);
            }
        }
        
        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewAuthors.SelectedRows.Count > 0)
            {
                using (LibraryContext context = new LibraryContext())
                {
                    BookForm formBook = new BookForm();

                    //Set author name in the coresponding text field in a new book form 
                    int authorID = (int)dataGridViewAuthors.SelectedRows[0].Cells["AuthorID"].Value;
                    formBook.setAuthor((string)dataGridViewAuthors.SelectedRows[0].Cells["FirstName"].Value + " "
                        + (string)dataGridViewAuthors.SelectedRows[0].Cells["LastName"].Value);

                    if (DialogResult.OK == formBook.ShowDialog())
                    {
                        Book b = new Book()
                        {
                            Title = formBook.FormBook.Title,
                            Genre = formBook.FormBook.Genre,
                            Author = formBook.FormBook.Author,
                            Publisher = formBook.FormBook.Publisher,
                        };
                        context.Books.Add(b);
                        context.SaveChanges();

                        //Increase number of books written by author
                        foreach (Author a in context.Authors)
                        {
                            if(a.AuthorID == authorID)
                            {
                                a.BooksWritten += 1;
                            }
                        }
                        context.SaveChanges();

                        //Add new relation between book and author
                        Relation newRel = new Relation();
                        newRel.AuthorID = authorID;
                        newRel.BookID = b.BookID;
                        context.Relations.Add(newRel);
                        context.SaveChanges();

                        LoadAuthors();
                        LoadBooks();
                        LoadOther(authorID);
                    }
                }
            }
            
        }

        private void buttonEditBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count > 0)
            {
                using (LibraryContext context = new LibraryContext())
                {
                    int bookID = (int)dataGridViewBooks.SelectedRows[0].Cells["BookID"].Value;
                    BookForm formBook = new BookForm();
                    formBook.FormBook = context.Books.First(x => x.BookID == bookID);
                    if (DialogResult.OK == formBook.ShowDialog())
                    {
                        context.SaveChanges();
                        LoadBooks();
                    }

                    //Refresh books by this author
                    if (dataGridViewAuthors.SelectedRows.Count > 0)
                    {
                        int authorID = (int)dataGridViewAuthors.SelectedRows[0].Cells["AuthorID"].Value;
                        string authorName = (string)dataGridViewAuthors.SelectedRows[0].Cells["FirstName"].Value
                            + " " + (string)dataGridViewAuthors.SelectedRows[0].Cells["LastName"].Value;

                        if (formBook.FormBook.Author == authorName)
                        {
                            LoadOther(authorID);
                        }
                    }
                }
            }
        }

        private void buttonRemoveBook_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo))
            {
                if (dataGridViewBooks.SelectedRows.Count > 0)
                {
                    int bookID = (int)dataGridViewBooks.SelectedRows[0].Cells["BookID"].Value;
                    using (LibraryContext context = new LibraryContext())
                    {
                        context.Books.Remove(context.Books.First(x => x.BookID == bookID));
                        context.SaveChanges();

                        if (dataGridViewAuthors.SelectedRows.Count > 0)
                        {
                            int authorID = (int)dataGridViewAuthors.SelectedRows[0].Cells["AuthorID"].Value;

                            //Decrease number of books written by author
                            foreach (Author a in context.Authors)
                            {
                                if (a.AuthorID == authorID)
                                {
                                    a.BooksWritten -= 1;
                                }
                            }
                            context.SaveChanges();

                            LoadOther(authorID);
                        }
                    }
                    LoadBooks();
                    LoadAuthors();
                }
            }
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            AuthorForm formAuthor = new AuthorForm();
            if (DialogResult.OK == formAuthor.ShowDialog())
            {
                using (LibraryContext context = new LibraryContext())
                {
                    Author a = new Author()
                    {
                        FirstName = formAuthor.FormAuthor.FirstName,
                        LastName = formAuthor.FormAuthor.LastName,
                        MainGenre = formAuthor.FormAuthor.MainGenre,
                        BooksWritten = formAuthor.FormAuthor.BooksWritten,
                    };
                    context.Authors.Add(a);
                    context.SaveChanges();
                    LoadAuthors();
                }
            }
        }

        private void buttonEditAuthor_Click(object sender, EventArgs e)
        {
            if (dataGridViewAuthors.SelectedRows.Count > 0)
            {
                using (LibraryContext context = new LibraryContext())
                {
                    int authorID = (int)dataGridViewAuthors.SelectedRows[0].Cells["AuthorID"].Value;
                    AuthorForm formAuthor = new AuthorForm();
                    formAuthor.FormAuthor = context.Authors.First(x => x.AuthorID == authorID);
                    if (DialogResult.OK == formAuthor.ShowDialog())
                    {
                        context.SaveChanges();
                        LoadAuthors();
                    }
                }
            }
        }

        private void buttonRemoveAuthor_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo))
            {
                if (dataGridViewAuthors.SelectedRows.Count > 0)
                {
                    int authorID = (int)dataGridViewAuthors.SelectedRows[0].Cells["AuthorID"].Value;
                    using (LibraryContext context = new LibraryContext())
                    {
                        context.Authors.Remove(context.Authors.First(x => x.AuthorID == authorID));
                        context.SaveChanges();
                    }
                    LoadAuthors();
                }
            }
        }
    }
}
