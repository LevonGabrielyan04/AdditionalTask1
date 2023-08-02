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
    }
}
