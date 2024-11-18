using Handlingform.Models;
using Microsoft.EntityFrameworkCore;

namespace Handlingform.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options
    ) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

    }
}
