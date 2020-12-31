using System;
using System.Collections.Generic;
using PizzaWorld.Domain.Singleton;
using PizzaWorld.Domain.Models;
using System.Linq;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Repo.Repos;
using System.Text;

namespace PizzaWorld.Client
{
    class Program
    {
        private static readonly ClientSingleton Client =
         ClientSingleton.Instance;
        public static AllRepo AllRepo = new AllRepo();

        static void Main(string[] args)
        {   
           SelectUserType();
        }
        static void UserView(User User)
        {
            UserStart(User);
            GetPizzas(User);
            Console.WriteLine(PrintLastOrders(User));
            Console.WriteLine("Your total is : $" + GetPrice(User));
            AllRepo.SaveOrder(User.Orders.Last());
        }

        static void SelectUserType()
        {
            Console.WriteLine("\nCustomer or Store");
            Console.WriteLine("---------------");
            var UserChoices = new List<string>{"Customer","Store"};
            UserChoices.ForEach(Console.WriteLine);
            
            int.TryParse(Console.ReadLine(),out int input);
            switch(input)
            {
                case 1:
                    CheckIfReturning();
                    break;
                case 2: 
                    StoreMenu(GetStore());
                    break;
                default:
                    Console.Error.WriteLine("\nPlease enter a valid choice");
                    break;
            }
        }

        static User UserStart(User user)
        {
            user.ChosenStore = GetStore();
            user.ChosenStore.CreateOrder();
            user.Orders.Add(user.ChosenStore.Orders.Last());
            return user;
        }
        static void CheckIfReturning()
        {
            Console.WriteLine("\nAre you a New or Returning User");
            Console.WriteLine("---------------");
            var UserChoices = new List<string>{"New","Returning"};
            UserChoices.ForEach(Console.WriteLine);
            int.TryParse(Console.ReadLine(),out int input);
            switch(input)
            {
                case 1:
                    UserView(CreateNewUser());
                    break;
                case 2: 
                    GetReturningUserOption(GetUser());
                    break;
                default:
                    Console.Error.WriteLine("\nPlease enter a valid choice");
                    break;
            }
        }

        static void StoreMenu(Store Store)
        {
            Console.WriteLine("\nWould you like to see Revenue or Past Orders?");
            Console.WriteLine("---------------");
            var UserChoices = new List<string>{"Revenue","Orders"};
            UserChoices.ForEach(Console.WriteLine);
            int.TryParse(Console.ReadLine(),out int input);
            switch(input)
            {
                case 1:
                    DisplayRevenueMenu(Store);
                    StoreMenu(Store);
                    break;
                case 2: 
                    DisplayPastOrders(Store);
                    StoreMenu(Store);
                    break;
                default:
                    Console.Error.WriteLine("\nPlease enter a valid choice");
                    break;
            }
        }

        static void DisplayRevenueMenu(Store Store)
        {
            Console.WriteLine("\nWould you like to see Weekly, Monthly, Yearly, or Total?");
            Console.WriteLine("---------------");
            var UserChoices = new List<string>{"Weekly","Monthly","Yearly","Total"};
            UserChoices.ForEach(Console.WriteLine);
            int.TryParse(Console.ReadLine(),out int input);
            switch(input)
            {
                case 1:
                    DisplayWeeklyRevenue(Store);
                    break;
                case 2: 
                    DisplayMonthlyRevenue(Store);
                    break;
                case 3: 
                    DisplayYearlyRevenue(Store);
                    break;
                case 4: 
                    DisplayTotalRevenue(Store);
                    break;
                default:
                    Console.Error.WriteLine("\nPlease enter a valid choice");
                    break;
            }
        }

        //Stolen
        public static DateTime StartOfWeek(DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }

        static void DisplayWeeklyRevenue(Store Store)
        {
            var Orders = AllRepo.GetOrderByStore(Store);
            decimal Revenue = 0;
            DateTime Sunday = StartOfWeek(DateTime.Now, DayOfWeek.Sunday);
            foreach (var order in Orders)
            {
                int result = DateTime.Compare(order.OrderTime,Sunday);
                if (result > 0)
                {
                    Revenue += order.Price; 
                }
            }
            Console.WriteLine("This week's Revenue = $" + Revenue);
        }
        static void DisplayYearlyRevenue(Store Store)
        {
            var Orders = AllRepo.GetOrderByStore(Store);
            decimal Revenue = 0;
            int year = DateTime.Now.Year;
            DateTime StartOfYear = new DateTime(year,1,1);
            foreach (var order in Orders)
            {
                int result = DateTime.Compare(order.OrderTime,StartOfYear);
                if (result > 0)
                {
                    Revenue += order.Price; 
                }
            }
            Console.WriteLine("This Year's Revenue = $" + Revenue);
        }
        static void DisplayTotalRevenue(Store Store)
        {
            var Orders = AllRepo.GetOrderByStore(Store);
            decimal Revenue = 0;
            foreach (var order in Orders)
            {
                Revenue += order.Price; 
            }
            Console.WriteLine("Total Revenue = $" + Revenue);
        }
        static void DisplayMonthlyRevenue(Store Store)
        {
            var Orders = AllRepo.GetOrderByStore(Store);
            decimal Revenue = 0;
            var date = DateTime.Now;
            DateTime FirstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            foreach (var order in Orders)
            {
                int result = DateTime.Compare(order.OrderTime,FirstDayOfMonth);
                if (result > 0)
                {
                    Revenue += order.Price; 
                }
            }
            Console.WriteLine("This Month's Revenue = $" + Revenue);
        }
        static string PrintLastOrders(User user)
        {    
            var sb = new StringBuilder();
            int pizzaCount = 0;
            foreach (var p in user.Orders.Last().Pizzas)
            {
                pizzaCount++;
                sb.AppendLine("\n"+ pizzaCount +". "+ p.GetType().Name +": "+p.Size+ ", " + p.Crust +" Crust with" );
                foreach(Topping toppings in p.Toppings)
                {
                    sb.Append("   "+toppings.name+"\n");
                }              
            }
            return $"You have selected this store: {user.ChosenStore} and ordered these pizzas:\n {sb.ToString()}";
        }
        static void PrintStoreOrders(Store Store)
        {
            var Orders = AllRepo.GetOrderByStore(Store);
            int ordercount = 0;
            foreach (var order in Orders)
            {
                decimal total = 0;
                ordercount++;
                total += order.Price; 
                Console.WriteLine("Order #" + ordercount + " - Price = $" + total +
                 " - Date = " + order.OrderTime.Date.ToString("MM-dd-yyyy") +
                  " at " + order.OrderTime.ToString("hh:mm:ss"));
            }
        }
        static void PrintUserOrders(User User)
        {
            var Orders = AllRepo.GetOrderByUser(User);
            int ordercount = 0;
            foreach (var order in Orders)
            {
                decimal total = 0;
                ordercount++;
                total += order.Price; 
                Console.WriteLine("Order #" + ordercount + " - Price = $" + total + 
                " - Date = " + order.OrderTime.Date.ToString("MM-dd-yyyy") + 
                " at " + order.OrderTime.ToString("hh:mm:ss"));
            }
        }
        static void GetReturningUserOption(User User)
        {
            Console.WriteLine("\nWould you like to create a new order or view old?");
            Console.WriteLine("---------------");
            var UserChoices = new List<string>{"New Order","View Previous Orders"};
            UserChoices.ForEach(Console.WriteLine);
            int.TryParse(Console.ReadLine(),out int input);
            switch(input)
            {
                case 1:
                    UserView(User);
                    break;
                case 2: 
                    PrintUserOrders(User);
                    GetReturningUserOption(User);
                    break;
                default:
                    Console.Error.WriteLine("\nPlease enter a valid choice");
                    break;
            }
        }
        static void DisplayUserOrders(User User)
        {
            AllRepo.DisplayOrderByUser(User);
        }
        static Store GetStore()
        {
            Console.WriteLine("\nChoose a Store");
            Console.WriteLine("---------------");
            AllRepo.DisplayStores();
            var Choice = int.TryParse(Console.ReadLine(),out int Input);
            if(Choice)
               if (CheckifExists(AllRepo.ReadStores().ToList().Count, Input))
                    return AllRepo.ReadOneStore(Input-1);
                else{
                    Console.Error.WriteLine("\nPlease Enter a Valid Choice");
                    GetStore();
                    return null;}
            else{
                Console.Error.WriteLine("\nPlease Enter a Valid Choice");
                GetStore();
                return null;}
        }

        static void DisplayPastOrders(Store StoreChoice)
        {
           // AllRepo.DisplayOrderByStore(StoreChoice);
            PrintStoreOrders(StoreChoice);
        }
        static User GetUser()
        {
            Console.WriteLine("\nChoose a User");
            Console.WriteLine("---------------");
            AllRepo.DisplayUser();
            var Choice = int.TryParse(Console.ReadLine(),out int Input);
            if(Choice)
               if (CheckifExists(AllRepo.ReadUser().ToList().Count, Input))
                    return AllRepo.ReadOneUser(Input-1);
                else{Console.Error.WriteLine("\nPlease Enter a Valid Choice");
                    GetUser();
                    return null;}
            else{Console.Error.WriteLine("\nPlease Enter a Valid Choice");
                GetUser();
                return null;}
        }
        static User CreateNewUser()
        {
            Console.WriteLine("\nEnter Name");
            Console.WriteLine("---------------");
            var Name = Console.ReadLine();
            User user = new User(Name);
            AllRepo.SaveUser(user);
            return user;
        }

        static Size GetSize()
        {
            Console.WriteLine("\nChoose a Size");
            Console.WriteLine("---------------");
            AllRepo.DisplaySize();
            var Choice = int.TryParse(Console.ReadLine(),out int Input);
            if(Choice)
               if (CheckifExists(AllRepo.ReadSize().ToList().Count, Input))
                    return AllRepo.ReadOneSize(Input-1);
                else{
                    Console.Error.WriteLine("\nPlease Enter a Valid Choice");
                    GetSize();
                    return null;}
            else{Console.Error.WriteLine("\nPlease Enter a Valid Choice");
                GetSize();
                return null;}
        }

        static Crust GetCrust()
        {
            Console.WriteLine("\nChoose a Crust");
            Console.WriteLine("---------------");
            AllRepo.DisplayCrust();
            var Choice = int.TryParse(Console.ReadLine(),out int Input);
            if(Choice)
               if (CheckifExists(AllRepo.ReadCrust().ToList().Count, Input))
                    return AllRepo.ReadOneCrust(Input-1);
                else{Console.Error.WriteLine("\nPlease Enter a Valid Choice");
                    GetCrust();
                    return null;}
            else{Console.Error.WriteLine("\nPlease Enter a Valid Choice");
                GetCrust();
                return null;}
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
                AllRepo.DisplayToppings(); 
                CheckifToppingExists(UserToppings);

                if(UserToppings.Count >= 2 && UserToppings.Count < 5)
                {
                    Console.WriteLine("\nYou've hit the minimum, would you like to add more?");
                    Console.WriteLine("Y or N");
                    if (Console.ReadLine().Equals("N"))
                    {
                        IsStillGettingToppings = false;
                    }
                }
                if (UserToppings.Count == 5)
                {
                    Console.WriteLine("You've hit the maximum amount of toppings");
                    IsStillGettingToppings = false;
                }
            }
            return UserToppings;
        }

        static void GetPizzas(User User)
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
                    PizzaList(Pizzas,TopOrder);
                }
                else
                {
                    Console.WriteLine("\nMinimum amout of pizzas selected, select another pizza? Y or N");
                    Console.WriteLine("---------------");
                    string UserChoice = Console.ReadLine();

                    if (UserChoice.Equals("Y"))
                    {
                        PizzaList(Pizzas,TopOrder);
                    }
                    else if (UserChoice.Equals("N")){StillSelecting = false;}
                    else{Console.Error.WriteLine("\nPlease Enter Y or N");}
                }
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
            User.Orders.Last().Price = total;
            return total;
        }

        static void PizzaList(List<string> Pizzas, Order TopOrder)
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
            Pizza.Toppings.Add(AllRepo.ReadOneTopping("Bacon"));
            Pizza.Toppings.Add(AllRepo.ReadOneTopping("Pepperoni"));
        }

        static void SetCheesePizza(Order TopOrder)
        {
            var Pizza = TopOrder.Pizzas.Last();
            Pizza.Size = GetSize();
            Pizza.Crust = GetCrust();
            Pizza.Toppings.Add(AllRepo.ReadOneTopping("Cheese"));
        }

        static bool CheckifExists(int ListSize, int Input)
        {
            if(Input <= ListSize && Input > 0)
                return true;
            else{return false;}
        }

        static void CheckifToppingExists(List<Topping> Toppings)
        {
            bool isValid = int.TryParse(Console.ReadLine(),out int Input);
            if(isValid)
            {
                if(Input <= AllRepo.ReadToppings().ToList().Count && Input > 0)
                    Toppings.Add(AllRepo.ReadOneTopping(Input-1));
                else
                {
                    Console.Error.WriteLine("\nPlease Enter a Valid Choice");
                    AllRepo.DisplayToppings();
                    CheckifToppingExists(Toppings);
                }
            }
            else
            {
                Console.Error.WriteLine("\nPlease Enter a Valid Choice");
                AllRepo.DisplayToppings();
                CheckifToppingExists(Toppings);
            }
        }
    }
}
