using System.Linq;

namespace Library
{
    public static class DbInitializer
    {
        public static void Initialize(LibraryContext context)
        {
            context.Database.EnsureCreated();
            // Look for any students.
            if (context.Authors.Any())
            {
                return; // DB has been seeded
            }
            var authors = new Author[]
            {
                new Author{FirstName="Carl", LastName="Jung", MainGenre="Psychology", BooksWritten=3},
                new Author{FirstName="Sigmund", LastName="Freud", MainGenre="Psychology", BooksWritten=3},
                new Author{FirstName="Isaac", LastName="Asimov", MainGenre="Sci-Fi", BooksWritten=3},
                new Author{FirstName="Douglas", LastName="Adams", MainGenre="Sci-Fi", BooksWritten=2},
                new Author{FirstName="Stephen", LastName="King", MainGenre="Horror", BooksWritten=2},
                new Author{FirstName="Yuval", LastName="Harari", MainGenre="Humanitarian", BooksWritten=3},
                new Author{FirstName="Walter", LastName="Isaacson", MainGenre="Biography", BooksWritten=3},
                new Author{FirstName="Fyodor", LastName="Dostoevsky", MainGenre="Philosophy", BooksWritten=2},
            };
            foreach (Author a in authors)
            {
                context.Authors.Add(a);
            }
            context.SaveChanges();
            var books = new Book[]
            {
                new Book{Title="The Red Book", Author="Carl Jung", Genre="Psychology", Publisher="Philemon Foundation"},
                new Book{Title="The Brothers Karamazov", Author="Fyodor Dostoevsky", Genre="Philosophy", Publisher="The Russian Messenger"},
                new Book{Title="Leonardo Da Vinci", Author="Walter Isaacson", Genre="Biography", Publisher="Simon and Schuster"},
                new Book{Title="Man and His Symbols",  Author="Carl Jung",Genre="Psychology", Publisher="Dell Publishing"},
                new Book{Title="The Hitchhiker's Guide to the Galaxy", Author="Douglas Adams", Genre="Sci-Fi", Publisher="Pan Books"},
                new Book{Title="The Bicentennial Man", Author="Isaac Asimov", Genre="Sci-Fi", Publisher="Ballantine Books"},
                new Book{Title="The Green Mile", Author="Stephen King", Genre="Horror", Publisher="Signet Books"},
                new Book{Title="The Innovators", Author="Walter Isaacson", Genre="Biography", Publisher="Simon and Schuster"},
                new Book{Title="Archetypes and the Collective Unconscious", Author="Carl Jung", Genre="Psychology", Publisher="Princeton University Press"},
                new Book{Title="21 Lessons for the 21st Century", Author="Yuval Harari", Genre="Humanitarian", Publisher="Jonathan Cape"},
                new Book{Title="Totem and Taboo",  Author="Sigmund Freud",Genre="Psychology", Publisher="Beacon Press"},
                new Book{Title="Foundation", Author="Isaac Asimov", Genre="Sci-Fi", Publisher="Gnome Press"},
                new Book{Title="The Ego and the Id",  Author="Sigmund Freud",Genre="Psychology", Publisher="Internationaler Psychoanalytischer Verlag"},
                new Book{Title="Sapiens: A Brief History of Humankind", Author="Yuval Harari", Genre="History", Publisher="Harper"},
                new Book{Title="The Interpretation of Dreams",  Author="Sigmund Freud",Genre="Psychology", Publisher="Franz Deuticke"},
                new Book{Title="The Restaurant at the End of the Universe", Author="Douglas Adams", Genre="Sci-Fi", Publisher="Pan Books"},
                new Book{Title="IT", Author="Stephen King", Genre="Horror", Publisher="Viking"},
                new Book{Title="I, Robot", Author="Isaac Asimov", Genre="Sci-Fi", Publisher="Gnome Press"},
                new Book{Title="Crime and Punishment", Author="Fyodor Dostoevsky", Genre="Philosophy", Publisher="Viking"},
                new Book{Title="Homo Deus: A Brief History of Tomorrow", Author="Yuval Harari", Genre="Sci-Fi", Publisher="Harvill Secker"},
                new Book{Title="Steve Jobs", Author="Walter Isaacson", Genre="Biography", Publisher="Simon and Schuster"},
            };
            foreach (Book b in books)
            {
                context.Books.Add(b);
                context.SaveChanges();
                foreach (Author a in authors)
                {
                    string authorName = a.FirstName + " " + a.LastName;
                    if (authorName == b.Author)
                    {
                        Relation r = new Relation { AuthorID = a.AuthorID, BookID = b.BookID };
                        context.Relations.Add(r);
                        context.SaveChanges();
                    }
                }
            }
            
        }
    }
}