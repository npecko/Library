namespace Library
{
    public class Relation
    {
        public int RelationID { get; set; }
        public int BookID { get; set; }
        public int AuthorID { get; set; }
        public Author Author { get; set; }
        public Book Book { get; set; }
    }
}
