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

        //todo Repos should be WAAAAAY more abstracted, override and overload
        //todo downsize check methods after abstracting repo
        //todo DB needs pizza items in order to make list dynamic - GetSelection()
        //todo Write tests
        //todo Read and Write to Db with Orders
        //------------------------------------------------------------------------
        static void Main(string[] args)
        {   
           UserView();
        }
        static void UserView()
        {
            //Get User
            var User = new User();
            UserStart(User);
            //Get Order
            GetSelection(User);
            //Print Pizza Order
            Console.WriteLine(User);
            //Print Total
            Console.WriteLine("Your total is : $" + GetPrice(User));

            StoreRepo.SaveOrder(User);
        }

        static User UserStart(User user)
        {
            //Display Store Choices
            Console.WriteLine("\nChoose a Store");
            Console.WriteLine("---------------");
            StoreRepo.DisplayStores();
            CheckifStoreExists(user);
            //Create Order
            user.ChosenStore.CreateOrder();
            user.Orders.Add(user.ChosenStore.Orders.Last());

            return user;
        }

        static Size GetSize()
        {
            Console.WriteLine("\nChoose a Size");
            Console.WriteLine("---------------");
            SizeRepo.DisplaySize();
            int.TryParse(Console.ReadLine(),out int SizeInput);
            return SizeRepo.ReadOneSize(SizeInput);
        }

        static Crust GetCrust()
        {
            Console.WriteLine("\nChoose a Crust");
            Console.WriteLine("---------------");
            CrustRepo.DisplayCrust();
            return CheckifCrustExists();
        }

        static List<Topping> GetToppings()
        {
            Boolean IsStillGettingToppings = true;
            var UserToppings = new List<Topping>();
            while(IsStillGettingToppings)
            {
                Console.WriteLine("\nChoose a Topping, Minimum 2");
                Console.WriteLine("Total Toppings: " + UserToppings.Count);
                Console.WriteLine("---------------");
                ToppingRepo.DisplayToppings(); 
                
                CheckifToppingExists(UserToppings);

                if(UserToppings.Count >= 2)
                {
                    Console.WriteLine("\nYou've hit the minimum, would you like to add more?");
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
                if(TopOrder.Pizzas.Count < 2)
                {
                    Console.WriteLine("\nSelect a pizza");
                    Console.WriteLine("---------------");
                    SelectPizza(Pizzas,TopOrder);
                }
                else
                {
                    Console.WriteLine("\nMinimum amout of pizzas selected, select another pizza? Y or N");
                    Console.WriteLine("---------------");
                    string UserChoice = Console.ReadLine();

                    if (UserChoice.Equals("Y"))
                    {
                        SelectPizza(Pizzas,TopOrder);
                    }
                    else if (UserChoice.Equals("N")){StillSelecting = false;}
                    else{Console.Error.WriteLine("\nPlease Enter Y or N");}
                }
            }
        }

        static void SelectPizza(List<string> Pizzas, Order TopOrder)
        {
            Pizzas.ForEach(Console.WriteLine);
            int.TryParse(Console.ReadLine(),out int input);
            switch(input)
            {
                case 1:
                    TopOrder.MakeCheesePizza();
                    SetCheesePizza(TopOrder);
                    break;
                case 2: 
                    TopOrder.MakeMeatPizza();
                    SetMeatPizza(TopOrder);
                    break;
                case 3:
                    TopOrder.MakeCustomPizza(GetCrust(), GetSize(),GetToppings());
                    break;
                default:
                    Console.Error.WriteLine("\nPlease enter a valid choice");
                    break;
            }
        }

        static void SetMeatPizza(Order TopOrder)
        {
            var Pizza = TopOrder.Pizzas.Last();
            Pizza.Size = GetSize();
            Pizza.Crust = GetCrust();
            Pizza.Toppings.Add(ToppingRepo.ReadOneTopping("Bacon"));
            Pizza.Toppings.Add(ToppingRepo.ReadOneTopping("Pepperoni"));
        }
        static void SetCheesePizza(Order TopOrder)
        {
            var Pizza = TopOrder.Pizzas.Last();
            Pizza.Size = GetSize();
            Pizza.Crust = GetCrust();
            Pizza.Toppings.Add(ToppingRepo.ReadOneTopping("Cheese"));
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
//---------------------------------------------------------------------Check

        static Crust CheckifSizeExists()
        {
            bool isValid = int.TryParse(Console.ReadLine(),out int Input);
            if(isValid)
            {
                if(Input <= CrustRepo.ReadCrust().ToList().Count && Input > 0)
                    return CrustRepo.ReadOneCrust(Input);
                else
                {
                    Console.Error.WriteLine("Please Enter a Valid Choice");
                    GetCrust();
                    return null;
                }
            }
            else
            {
                Console.Error.WriteLine("Please Enter a Valid Choice");
                GetCrust();
                return null;
            }
        }

        static Crust CheckifCrustExists()
        {
            bool isValid = int.TryParse(Console.ReadLine(),out int Input);
            if(isValid)
            {
                if(Input <= CrustRepo.ReadCrust().ToList().Count && Input > 0)
                    return CrustRepo.ReadOneCrust(Input);
                else
                {
                    Console.Error.WriteLine("Please Enter a Valid Choice");
                    GetCrust();
                    return null;
                }
            }
            else
            {
                Console.Error.WriteLine("Please Enter a Valid Choice");
                GetCrust();
                return null;
            }
        }
        static void CheckifStoreExists(User user)
        {
            bool isValid = int.TryParse(Console.ReadLine(),out int Input);
            if(isValid)
            {
                if(Input <= StoreRepo.ReadStores().ToList().Count && Input > 0)
                    user.ChosenStore = StoreRepo.ReadOneStore(Input);
                else
                {
                    Console.Error.WriteLine("Please Enter a Valid Choice");
                    UserStart(user);
                }
            }
            else
            {
                Console.Error.WriteLine("Please Enter a Valid Choice");
                UserStart(user);
            }
        }
        
        static void CheckifToppingExists(List<Topping> Toppings)
        {
            var UserToppings = new List<Topping>();
            bool isValid = int.TryParse(Console.ReadLine(),out int Input);
            if(isValid)
            {
                if(Input <= ToppingRepo.ReadToppings().ToList().Count && Input > 0)
                    Toppings.Add(ToppingRepo.ReadOneTopping(Input));
                else
                {
                    Console.Error.WriteLine("\nPlease Enter a Valid Choice");
                    ToppingRepo.DisplayToppings();
                    CheckifToppingExists(Toppings);
                }
            }
            else
            {
                Console.Error.WriteLine("\nPlease Enter a Valid Choice");
                ToppingRepo.DisplayToppings();
                CheckifToppingExists(Toppings);
            }
        }
    }
}
