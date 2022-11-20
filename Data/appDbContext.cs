using High_precisionMechanics.Models;
using Microsoft.EntityFrameworkCore;

namespace High_precisionMechanics.Data
{
    public class appDbContext : DbContext
    {
        public appDbContext(DbContextOptions<appDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Agreement> Agreements { get; set; }
    }
}
