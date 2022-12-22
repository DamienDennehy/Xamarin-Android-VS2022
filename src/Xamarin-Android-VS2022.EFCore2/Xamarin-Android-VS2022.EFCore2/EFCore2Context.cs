using Microsoft.EntityFrameworkCore;

namespace Xamarin_Android_VS2022.EFCore2
{
    public class EFCore2Context : DbContext
    {
        public DbSet<AppSetting> AppSettings { get; set; }

        public EFCore2Context() { }

        public EFCore2Context(DbContextOptions<EFCore2Context> options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite($"Filename=EFCore2.db");
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
