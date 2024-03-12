using Microsoft.EntityFrameworkCore;

namespace Mission10_FugeAPI 
{
    public class BowlerContext : DbContext 
    {
        public BowlerContext(DbContextOptions<BowlerContext> options) : base(options) {

        }

        public DbSet<Bowler> Bowlers { get; set; }
    }
}