using Microsoft.EntityFrameworkCore;

namespace Bookish;

public class BookishDbContext : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=bookish;User Id=bookish;Password=bookish;");
    }
}