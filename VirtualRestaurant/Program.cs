using System;
using VirtualRestaurant;

namespace VirtualRestaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            // simulating ordering 3 cheeseburgers and 2 grilled chicken
            Restaurant restaurant = new Restaurant();

            restaurant.PrintMenu();

            Customer cust1 = new Customer("James", "12345", "james@email.com", "home", false, false);
            
            restaurant.TakeOrder(cust1, "Cheeseburger", 2);
            restaurant.TakeOrder(cust1, "Grilled Chicken", 3);

            Payment payment = new Payment("Visa", "54321", false);
            OrderHandler handler = new OrderHandler();
            payment.ProcessPayment(restaurant, payment);

            foreach (Order order in restaurant.ordersList)
            {
                restaurant.ReleaseOrder(order, handler, payment);
            }
            
            
        }
    }
}