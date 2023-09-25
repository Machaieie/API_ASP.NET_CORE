using Microsoft.EntityFrameworkCore;
using Produtos_API_ASP.NET.Model;

namespace Produtos_API_ASP.NET.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) 
        { 

        }

        public DbSet<UserModel> User { get; set; }
        public DbSet<UserModel> Product { get; set; }
        public DbSet<UserModel> Stock { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
