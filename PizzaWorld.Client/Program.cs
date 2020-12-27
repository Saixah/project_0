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
        public static OrderRepo OrderRepo = new OrderRepo();

        static void Main(string[] args)
        {   
           UserView();
        }
        static void UserView()
        {
            //Get User
            var User = UserStart();
            //Get Order
            GetSelection(User);
            //Print Pizza Order
            Console.WriteLine(User);
            //Print Total
            Console.WriteLine("Your total is : " + GetPrice(User));

            OrderRepo.SaveOrder(User);
        }

        static User UserStart()
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

            return user;
        }

        static Size GetSize()
        {
            Console.WriteLine("Choose a Size");
            SizeRepo.DisplaySize();
            int.TryParse(Console.ReadLine(),out int SizeInput);
            return SizeRepo.ReadOneSize(SizeInput);
        }

        static Crust GetCrust()
        {
            Console.WriteLine("Choose a Crust");
            CrustRepo.DisplayCrust();
            int.TryParse(Console.ReadLine(),out int CrustInput);
            return CrustRepo.ReadOneCrust(CrustInput);
        }

        static List<Topping> GetToppings()
        {
            Boolean IsStillGettingToppings = true;
            var UserToppings = new List<Topping>();
            
            while(IsStillGettingToppings)
            {
                Console.WriteLine("Choose a Topping, Minimum 2");
                Console.WriteLine("Total Toppings: " + UserToppings.Count+"\n");
                ToppingRepo.DisplayToppings(); 
                
                int.TryParse(Console.ReadLine(),out int ToppingInput);
                UserToppings.Add(ToppingRepo.ReadOneTopping(ToppingInput));

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
            return UserToppings;
        }

        static void GetSelection(User User)
        {
            var Pizzas = new List<string>{"CheesePizza","MeatPizza","CustomPizza"};

            //Handles Order
            var StillSelecting= true;
            var TopOrder = User.Orders.Last();

            //When able to read pizzas from stores, this will need to change
            while (StillSelecting)
            {
                Console.WriteLine("Select a Pizza? Y or N");
                string UserChoice = Console.ReadLine();

                if (UserChoice.Equals("Y"))
                {
                    Pizzas.ForEach(Console.WriteLine);
                    int.TryParse(Console.ReadLine(),out int input);
                    switch(input)
                    {
                        case 1:
                            TopOrder.MakeCheesePizza();
                            break;
                        case 2: 
                            TopOrder.MakeMeatPizza();
                            break;
                        case 3:
                            TopOrder.MakeCustomPizza(GetCrust(), GetSize(),GetToppings());
                            break;
                        default:
                            Console.WriteLine("Please enter a valid choice");
                            break;
                    }
                }
                else if (UserChoice.Equals("N")){StillSelecting = false;}
                else{Console.WriteLine("Please Enter Y or N");}
            }
        }

        static decimal GetPrice(User User)
        {
            decimal total=0;
            foreach (APizzaModel pizza in User.Orders.Last().Pizzas)
            {
                total += pizza.Crust.price;
                total += pizza.Size.price;
                foreach(Topping topping in pizza.Toppings)
                {
                    total+=topping.price;
                }
            }
            return total;
        }
    }
}
