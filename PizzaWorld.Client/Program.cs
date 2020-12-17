using System;
using System.Collections.Generic;
using PizzaWorld.Domain.Singleton;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Client
{
    class Program
    {
        static void Main(string[] args)
        {
           var cs = ClientSingleton.Instance;
           // Greeting();
        }

        static void Greeting()
        {
            
            Console.WriteLine("Welcome to PizzaPalace");
            Console.Write("Enter 1 if you are an Customer | ");
            Console.Write("Enter 2 if you are an Employee \n");
            CheckUserType();
        }

        static void CheckUserType()
        {
            try
            {
                string UserEntry = Console.ReadLine();
                if (UserEntry != null)
                {
                    int UserResult = Int32.Parse(UserEntry);
                    switch(UserResult)
                    {
                        case 1:
                            Console.WriteLine("Welcome Customer!");
                            break;
                        case 2:
                            Console.WriteLine("Welcome Employee!");
                            break;
                        default:
                            Console.WriteLine("Please Enter a valid entry \n");
                            Greeting();
                            break;
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Please Enter a Number \n");
                Greeting();
            }
        }

        static void CustomerCheckIn()
        {
            Console.Write("Enter 1 if you already have an account | ");
            Console.Write("Enter 2 to create a new account \n");
        }

        static User CreateUser(string name)
        {
            return new User(name);
        }

        static List<Store> GetAllStores()
        {
            return new List<Store>()
            {
                new Store()
            };
        }

        static void PrintAllStores()
        {
            foreach(var store in GetAllStores())
            {
                Console.WriteLine(store);
            }
        }
    }
}
