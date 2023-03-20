using System;
using VirtualRestaurant;

namespace VirtualRestaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            RestaurantMenu restaurantMenu = new RestaurantMenu();
            restaurantMenu.MainMenu();
        }
    }
}