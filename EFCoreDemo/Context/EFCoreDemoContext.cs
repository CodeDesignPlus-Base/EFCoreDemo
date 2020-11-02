using EFCoreDemo.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace EFCoreDemo.Context
{
    public class EFCoreDemoContext : DbContext
    {
        protected EFCoreDemoContext()
        {
        }

        public EFCoreDemoContext([NotNull] DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var user = modelBuilder.Entity<User>();

            user.Property(x => x.Id).UseIdentityColumn();
            user.Property(x => x.Name).HasColumnType("varchar(128)").IsRequired();
            user.Property(x => x.Username).HasColumnType("varchar(64)").IsRequired();

            user.HasOne(x => x.Role).WithMany(x => x.Users).HasForeignKey(x => x.IdRole);
        }

        public DbSet<User> User { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Role> Role { get; set; }
    }
}
