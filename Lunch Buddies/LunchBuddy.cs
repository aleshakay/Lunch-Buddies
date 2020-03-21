using System;
using System.Collections.Generic;
using System.Text;

namespace Lunch_Buddies
{
    class LunchBuddy
    {
        public string FirstName { get; set; }
        public string LastName { get;set; }

        public LunchBuddy(string firstName, string lastName)  //constructor
        {
            FirstName = "Alice";
            LastName = "Jenkins";

        }
        public string Eat()
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} + {LastName} is at {restaurant.Name}");
            return restaurant.Name;
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{FirstName} +{LastName} ate {food} today.");
        }
    }
}
