using Microsoft.EntityFrameworkCore;

namespace linq_demo.Models
{
    public class PlayerDbContext : DbContext
    {
        public PlayerDbContext(DbContextOptions<PlayerDbContext> options) : base (options) { }
        public DbSet<player> players { get; set; }
    }
}
