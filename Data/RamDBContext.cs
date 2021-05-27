using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;
namespace Data
{   
    public class RamDBContext : DbContext {
        public RamDBContext (DbContextOptions<RamDBContext> options) : base (options) { }
        public DbSet<TaskItem> TaskItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}