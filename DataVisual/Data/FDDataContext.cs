using Microsoft.EntityFrameworkCore;

namespace DataVisual.Data
{
    public class FDDataContext : DbContext
    {
        public FDDataContext(DbContextOptions<FDDataContext> options) : base(options) { }
        public DbSet<FD1RUL> FD1RULs { get; set; }
    }
}
