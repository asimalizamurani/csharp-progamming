using Microsoft.EntityFrameworkCore;
using webdemo.Models;

namespace webdemo.Data
{
    public class ApplicationDb : DbContext
    {
        public ApplicationDb(DbContextOptions<ApplicationDb> options) : base(options) { }

        public DbSet<UserModel> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserModel>().HasData(
                new UserModel { userId = 1, FirstName = "Asim", LastName = "Ali", Email = "asim@gmail.com", Password = "12345" });
        }
    }
}
