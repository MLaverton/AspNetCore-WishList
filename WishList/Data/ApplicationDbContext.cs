namespace WishList.Data
{
    using Microsoft.EntityFrameworkCore;

    using WishList.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {
              
        }

        public DbSet<Item> Items { get; set; }
    }
}
