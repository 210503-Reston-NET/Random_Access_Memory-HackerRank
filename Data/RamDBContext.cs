using Microsoft.EntityFrameworkCore;
namespace Data
{   
    public class RamDBContext : DbContext {
        public RamDBContext (DbContextOptions<RamDBContext> options) : base (options) { }
        public DbSet<EntityName> EntityNames { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModel.Creating(modelBuilder);
        }
    }
}