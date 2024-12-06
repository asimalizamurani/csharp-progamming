using formpractice.Models;
using Microsoft.EntityFrameworkCore;

namespace formpractice.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> product { get; set; }
    }
}
