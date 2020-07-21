using System.Collections.Generic;

namespace Library
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MainGenre { get; set; }
        public int BooksWritten { get; set; }
        public ICollection<Relation> Relations { get; set; }
    }
}
