namespace Bookish;

public class Author
{
    public int Id { get; set; }
    public string Name { get; set; }   
    public List<Book> Books { get; set; }
    public string AuthorImage { get; set; }
    public string AuthorBio { get; set; }
}