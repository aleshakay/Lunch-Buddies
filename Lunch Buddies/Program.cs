using System;
using System.Collections.Generic;

namespace Lunch_Buddies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lunch Program");

            List<LunchBuddy> companions = new List<LunchBuddy> { };
            companions.Add(new LunchBuddy("Nathan", "Pride"));
            companions.Add(new LunchBuddy("Minor", "Reed"));

            var lunchBuddy = new LunchBuddy("I Do Not", "know");

            lunchBuddy.Eat();
            lunchBuddy.Eat("cake");
            lunchBuddy.Eat(companions);
            lunchBuddy.Eat(companions, "cake");



        }
    }
}
