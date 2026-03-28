using Web_Tuan5.Models;
using Microsoft.EntityFrameworkCore;
using Web_Tuan5.Models;

namespace Web_Tuan5.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}