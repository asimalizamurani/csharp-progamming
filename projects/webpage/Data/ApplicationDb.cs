using Microsoft.EntityFrameworkCore;
using webpage.Models;

namespace webpage.Data
{
    public class ApplicationDb : DbContext
    {
        public ApplicationDb(DbContextOptions<ApplicationDb> options) : base(options) { }

        public DbSet<RegisterModel> registers { get; set; }
        public DbSet<LoginModel> logins { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Check if any users exist in the database (to prevent adding duplicate data)
            modelBuilder.Entity<RegisterModel>().HasData(
                new RegisterModel
                {
                    Id = 1,
                    UserName = "asim",
                    Email = "asim@gmail.com",
                    Password = "asim123"
                },
                new RegisterModel
                {
                    Id = 2,
                    UserName = "mohsin",
                    Email = "mohsin@gmail.com",
                    Password = "mohsin123"
                }
            );
        }

    }
}
