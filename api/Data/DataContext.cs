using Microsoft.EntityFrameworkCore;
using Entities;

namespace api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options):base(options)
        {


        }

        public DbSet<AppUser> Users { get; set; }
    }
}