using System;
using System.Collections.Generic;
using PizzaWorld.Domain.Singleton;
using PizzaWorld.Domain.Models;
using System.Linq;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Client.Repo;

namespace PizzaWorld.Client
{
    class Program
    {
        private static readonly ClientSingleton Client =
         ClientSingleton.Instance;
        public static StoreRepo StoreRepo = new StoreRepo();
        public static ToppingRepo ToppingRepo = new ToppingRepo();
        public static SizeRepo SizeRepo = new SizeRepo();
        public static CrustRepo CrustRepo = new CrustRepo();

        static void Main(string[] args)
        {   
            //SqlClient.DisplayToppings();
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
            //Create User
            User user = new User();
            //Display Store Choices
            StoreRepo.DisplayStores();
            //User Makes Choice
            int.TryParse(Console.ReadLine(),out int storeInput);
            user.ChosenStore = StoreRepo.ReadOneStore(storeInput);

            //Create Order
            user.ChosenStore.CreateOrder();
            user.Orders.Add(user.ChosenStore.Orders.Last());

            // Display Pizzas from Chosen Stor
            // Having trouble adding Select Pizzas to DB 
            // var Pizzas = SqlClient.GetPizzasFromStore(UserInput);
            var Pizzas = new List<string>
            {
                "CheesePizza","MeatPizza","CustomPizza"
            };

            //--Assumtion that all stores offer same toppings, sizes, and crusts
            var Toppings = ToppingRepo.ReadToppings();
            // var Crusts = CrustRepo.ReadCrust();
            var Size = SizeRepo.ReadSize();

            //Handles Order
            var StillSelecting = true;
            var TopOrder = user.Orders.Last();

            //todo Break into modular - put in own method
            //When able to read pizzas from stores, this will need to change
            while (StillSelecting)
            {
                Console.WriteLine("Select a Pizza? Y or N");
                string UserChoice = Console.ReadLine();

                if (UserChoice.Equals("Y"))
                {
                    if (Pizzas == null)
                    {
                        Console.WriteLine("This store offers no pizzas");
                    }
                    else
                    {
                        Pizzas.ForEach(Console.WriteLine);
                    }
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
                            Console.WriteLine("Choose a Size");
                            SizeRepo.DisplaySize();
                            var UserSize = SizeRepo.ReadOneSize(Console.ReadLine());

                            Console.WriteLine("Choose a Crust");
                            CrustRepo.DisplayCrust();
                            var UserCrust = CrustRepo.ReadOneCrust(Console.ReadLine());

                            Boolean IsStillGettingToppings = true;
                            var UserToppings = new List<Topping>();
                            
                            while(IsStillGettingToppings)
                            {
                                Console.WriteLine("Choose a Topping, Minimum 2");
                                Console.WriteLine("Total Toppings: " + UserToppings.Count+"\n");
                                ToppingRepo.DisplayToppings(); 
                                
                                UserToppings.Add(ToppingRepo.ReadOneTopping(Console.ReadLine()));

                                if(UserToppings.Count >= 2)
                                {
                                    Console.WriteLine("You've hit the minimum, would you like to add more?");
                                    Console.WriteLine("Y or N");
                                    if (Console.ReadLine().Equals("N"))
                                    {
                                        IsStillGettingToppings = false;
                                    }
                                }
                                else if (UserToppings.Count == 50)
                                {
                                    Console.WriteLine("You've hit the maximum");
                                    IsStillGettingToppings = false;
                                }
                            }
                            // TopOrder.MakeCustomPizza(UserCrust, UserSize, UserToppings);
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
