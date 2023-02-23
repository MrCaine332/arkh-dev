using Microsoft.EntityFrameworkCore;
using ComponentsWebLibraryAPI.Models;

namespace ComponentsWebLibraryAPI.DataAccess
{
    public class MySQLDbContext : DbContext
    {
        public MySQLDbContext(DbContextOptions<MySQLDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<User> Users { get; set; }

    }
}
