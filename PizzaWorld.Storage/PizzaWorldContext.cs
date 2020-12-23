using Microsoft.EntityFrameworkCore;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Storage
{
    public class PizzaWorldContext : DbContext
    {
        public DbSet<Store> Stores { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=isaiahpizzaworld.database.windows.net;Initial Catalog=isaiahpizzaworlddb;User ID=sqladmin;Password=;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Store>().HasKey(s => s.EntityId);
            builder.Entity<User>().HasKey(u => u.EntityId);
            builder.Entity<APizzaModel>().HasKey(p => p.EntityId);
            builder.Entity<Order>().HasKey(o => o.EntityId);
            builder.Entity<Topping>().HasKey(t => t.EntityId);
            builder.Entity<Size>().HasKey(v => v.EntityId);
            builder.Entity<Crust>().HasKey(c => c.EntityId);
        }
    }
}