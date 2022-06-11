using Microsoft.EntityFrameworkCore;

namespace DataVisual.Data
{
    public class FDDataContext : DbContext
    {
        public FDDataContext(DbContextOptions<FDDataContext> options) : base(options) { }
        public DbSet<FD1RUL> FD1RULs { get; set; }
        public DbSet<FD1TEST> FD1TESTs { get; set; }
        public DbSet<FD1TRAIN> FD1TRAINs { get; set; }

        public DbSet<FD2RUL> FD2RULs { get; set; }
        public DbSet<FD2TEST> FD2TESTs { get; set; }
        public DbSet<FD2TRAIN> FD2TRAINs { get; set; }

        public DbSet<FD3RUL> FD3RULs { get; set; }
        public DbSet<FD3TEST> FD3TESTs { get; set; }
        public DbSet<FD3TRAIN> FD3TRAINs { get; set; }

        public DbSet<FD4RUL> FD4RULs { get; set; }
        public DbSet<FD4TEST> FD4TESTs { get; set; }
        public DbSet<FD4TRAIN> FD4TRAINs { get; set; }
    }
}
