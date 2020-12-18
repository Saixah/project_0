using System.Collections.Generic;

namespace PizzaWorld.Domain.Models
{
    public class User
    {
        public Store ChosenStore { get; set; }
        public List<Order> Orders { get; set; }

        public override string ToString()
        {
            return $"I have selected this store : {ChosenStore}";
        }
    }  
}