using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UWA.Entities;

namespace UWA.DataAccess
{
    public class UWADbContext : IdentityDbContext<ApplicationUser>
    {
        public UWADbContext() { }
        public UWADbContext(DbContextOptions<UWADbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB; Database=UnityApi;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(new
            {
                Id = "1",
                Name = "admin",
                NormalizedName = "admin"
            });

            builder.Entity<IdentityRole>().HasData(new
            {
                Id = "2",
                Name = "user",
                NormalizedName = "user"
            });

            base.OnModelCreating(builder);
        }

        public DbSet<Sample> Samples { get; set; }
    }
}
