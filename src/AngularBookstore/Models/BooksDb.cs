using Microsoft.Data.Entity;

namespace AngularBookstore.Models
{
    public class BooksDb : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}