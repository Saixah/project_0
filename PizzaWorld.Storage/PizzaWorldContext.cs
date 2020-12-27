using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Storage
{
    public class PizzaWorldContext : DbContext
    {
        public DbSet<Store> Stores { get; set; }
        public DbSet<Topping> Topping {get; set;}
        public DbSet<Crust> Crust {get; set;}
        public DbSet<Size> Size {get; set;}
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=isaiahpizzaworld.database.windows.net;Initial Catalog=isaiahpizzaworlddb;User ID=sqladmin;Password=Oblivion1234;");
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

            SeedData(builder);
        }

        protected void SeedData(ModelBuilder builder)
        {
            // List<APizzaModel> pizzas = new List<APizzaModel>()
            // {
            //   new MeatPizza(),
            //   new CheesePizza(),
            //   new CustomPizza()  
            // };
            // List<APizzaModel> pizzas2 = new List<APizzaModel>()
            // {
            //   new MeatPizza(),
            //   new CustomPizza()  
            // };
            
            builder.Entity<Store>(b => 
            {
                b.HasData(new List<Store>{
                    new Store() {Name = "One"},
                    new Store() {Name = "Two"},
                    new Store() {Name = "Three"}
                });
            });    

            builder.Entity<Topping>().HasData(new List<Topping>
            {
               new Topping("Pepperoni", 2),
               new Topping("Pineapple", 6),
               new Topping("Bacon", 3),
               new Topping("Gold", 100),
               new Topping("Jalapenos", 60),
               new Topping("Cheese", 1)
            });

            builder.Entity<Size>().HasData(new List<Size>
            {
                new Size("Small", 12),
                new Size("Medium",16),
                new Size("Large", 22),
                new Size("X-Large", 28)
            });

            builder.Entity<Crust>().HasData(new List<Crust>
            {
                new Crust("Thin", 2),
                new Crust("Thick", 3),
                new Crust("Stuffed",5)
            });
        }


    }
}