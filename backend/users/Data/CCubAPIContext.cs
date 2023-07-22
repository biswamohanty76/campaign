
using Microsoft.EntityFrameworkCore;

namespace CCubAPI.Data
{
    public class CCubAPIContext : DbContext
    {
        public CCubAPIContext (DbContextOptions<CCubAPIContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure default schema
            modelBuilder.HasDefaultSchema("Admin");
        }
        public DbSet<CCubAPI.Tenants.Tenant> Tenant { get; set; } = default!;
        public DbSet<CCubAPI.Tenants.User> User { get; set; } = default!;
    }
}
