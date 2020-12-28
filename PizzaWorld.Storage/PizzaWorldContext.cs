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
            builder.UseSqlServer("Server=isaiahpizzaworld.database.windows.net;Initial Catalog=isaiahpizzaworlddb;User ID=sqladmin;Password=Password1234;");
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
                // b.HasData(new List<Store>{
                //     new Store() {Name = "One"},
                //     new Store() {Name = "Two"},
                //     new Store() {Name = "Three"}
                // });
                
            });    

            builder.Entity<Topping>().HasData(new List<Topping>
            {
               new Topping(){name ="Pepperoni", price = 2},
               new Topping(){name ="Pineapple",price = 6},
               new Topping(){name ="Bacon",price = 3},
               new Topping(){name ="Gold",price = 100},
               new Topping(){name ="Jalapenos",price = 60},
               new Topping(){name = "Cheese",price = 1}
            });

            builder.Entity<Size>().HasData(new List<Size>
            {
                new Size{name ="Small",price = 12},
                new Size{name ="Medium",price =16},
                new Size{name ="Large",price = 22},
                new Size{name ="X-Large",price = 28}
            });

            builder.Entity<Crust>().HasData(new List<Crust>
            {
                new Crust{name ="Thin",price = 2},
                new Crust{name ="Thick",price = 3},
                new Crust{name ="Stuffed",price =5}
            });
        }


    }
}