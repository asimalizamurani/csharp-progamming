
using Microsoft.EntityFrameworkCore;
using practicemodel.Models;

namespace practicemodel.Data
{
    public class ApplicationDb : DbContext
    {
        public ApplicationDb(DbContextOptions<ApplicationDb> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, UserName = "Asim", Email = "asim@gmail.com", Password = "asim123" },
                new User { Id = 2, UserName = "Mohsin", Email = "mohsin@gmail.com", Password = "mohsin123" },
                new User { Id = 3, UserName = "Ali", Email = "ali@gmail.com", Password = "ali123" }
                );
        }
    }
}
