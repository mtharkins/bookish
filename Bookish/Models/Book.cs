namespace Bookish;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }  
    public Author Author { get; set; } 
    public string Blurb { get; set; }
    public string ImgCoverURL { get; set; }
}