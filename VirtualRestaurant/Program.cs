using System;
using VirtualRestaurant;

namespace VirtualRestaurant
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // Create a new restaurant
            Restaurant restaurant = new Restaurant();

          

            // Print the restaurant's menu
            Console.WriteLine("Restaurant Menu:");
            foreach (var menuItem in restaurant.menu)
            {
                Console.WriteLine($"{menuItem.Key} - Price: {menuItem.Value}");
            }
        }
    }
}