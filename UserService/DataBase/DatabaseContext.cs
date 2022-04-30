using Microsoft.EntityFrameworkCore;
using UserService.DataBase.Entities;

namespace UserService.DataBase
{
    public class DatabaseContext:DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-B04P1PL\SQLEXPRESS; Initial Catalog=DataBase; Integrated Security=True");
        }
    }
}
