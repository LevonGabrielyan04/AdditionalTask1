using LracucichTask1.Models;
using Microsoft.EntityFrameworkCore;

namespace LracucichTask1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        DbSet<Customer> Customers { get;set; }
        DbSet<Service> Services { get;set; }
        DbSet<Subsriber> Subscribers { get;set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>()
                .HasMany(o => o.Subsribers)
                .WithOne(c => c.Customer)
                .IsRequired();
            modelBuilder.Entity<Customer>()
                .Property(p => p.FirstName)
                .HasMaxLength(20);
            modelBuilder.Entity<Customer>()
                .Property(p => p.SecondName)
                .HasMaxLength(20);
                
            modelBuilder.Entity<Customer>()
                .HasIndex(c => new {c.FirstName,c.SecondName});

            modelBuilder.Entity<Service>()
                .HasMany(o => o.Subscribers)
                .WithMany(c => c.Services)
                .UsingEntity(join => join.ToTable("SubscriberService"));

            modelBuilder.Entity<Subsriber>()
                .HasCheckConstraint("Account","Account>=0");

        }
    }
}
