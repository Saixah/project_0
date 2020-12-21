using System;
using System.Collections.Generic;
using PizzaWorld.Domain.Singleton;
using PizzaWorld.Domain.Models;
using System.Linq;

namespace PizzaWorld.Client
{
    class Program
    {
        private static readonly ClientSingleton Client 
                            = ClientSingleton.Instance;
        static void Main(string[] args)
        {   
           UserView();
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
            catch(Exception)
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

        static void UserView()
        {
            User user = new User();

            Client.DisplayStores();

            user.ChosenStore = Client.SelectStore();
            user.ChosenStore.CreateOrder();
            user.Orders.Add(user.ChosenStore.Orders.Last());

            // HARDCODED--make into dynamic, allow store to change
            var Pizzas = new List<string>(){ "Cheese","Meat","Custom" };

            // HARDCODED--make into dynamic, allow user {Customer} to change
            // todo make different toppings list, one for store to give options,
            // one for User to pick out of
            var Toppings = new List<string>() { "Pineapple","Jalepeno","Chicken" };
            
            var StillSelecting = true;
            var TopOrder = user.Orders.Last();

            //todo Break into modular - put in own method
            while (StillSelecting)
            {
                Console.WriteLine("Select a Pizza? Y or N");
                string UserChoice = Console.ReadLine();

                if (UserChoice.Equals("Y"))
                {
                    Pizzas.ForEach(Console.WriteLine);
                    int.TryParse(Console.ReadLine(),out int input);

                    //Possible Switch to Delegates / put in own method
                    switch(input)
                    {
                        case 1:
                            TopOrder.MakeCheesePizza();
                            break;
                        case 2: 
                            TopOrder.MakeMeatPizza();
                            break;
                        case 3:
                            //todo get pizza params from user
                            TopOrder.MakeCustomPizza("Thick", "Large", Toppings);
                            break;
                        default:
                            Console.WriteLine("Please enter a valid choice");
                            break;
                    }
                }
                else if (UserChoice.Equals("N"))
                {
                    StillSelecting = false;
                }
                else
                {
                    Console.WriteLine("Please Enter Y or N");
                }
            }
            Console.WriteLine(user);
        }
    }
}
