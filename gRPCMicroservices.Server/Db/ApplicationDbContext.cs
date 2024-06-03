using Microsoft.EntityFrameworkCore;

namespace gRPCMicroservices.Server.Db
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Models.User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
