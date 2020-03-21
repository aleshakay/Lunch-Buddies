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
            FirstName = firstName;
            LastName = lastName;

        }
        public string Eat()
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is currenty at the world famous {restaurant.Name}");
            return restaurant.Name;
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{FirstName} {LastName} ate {food} today.");
        }

        public void Eat(List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            foreach (var companion in companions)
            {
                Console.WriteLine($"At {restaurant.Name}, {companion.FirstName} {companion.LastName} ate lunch");
            }
        }

        public void Eat(List<LunchBuddy> companions,string food)
        {
            var restaurant = new Restaurant();
            foreach (var companion in companions)
            {
                Console.WriteLine($"While at {restaurant.Name},{FirstName} and {companion.FirstName} where partying there butts off and eating {food}");
            }
        }
    }
}
