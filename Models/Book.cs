using System.Collections.Generic;

namespace Library
{
    public class Book
    {
        public int BookID { get; set; }
        public string Author { get; set; }
        public string Title { get; set; } 
        public string Genre { get; set; }
        public string Publisher { get; set; }
        public ICollection<Relation> Relations { get; set; }
    }
}