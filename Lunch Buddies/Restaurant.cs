using System;
using System.Collections.Generic;
using System.Text;

namespace Lunch_Buddies
{
    class Restaurant
    {
        private List <string> RestaurantNames { get; set; }
        public string Name { get; set; }

        public Restaurant()
        {
            var restaurants = new List<string>()
            {
                "Helens",
                "Bobs SteakHouse",
                "Melting Pot",
                "Royal Reeds",
                "AReeds"
            };

            RestaurantNames = restaurants;

            Random rnd = new Random();
            int n = rnd.Next(RestaurantNames.Count);
            Name = RestaurantNames[n];
        }
    }
}
