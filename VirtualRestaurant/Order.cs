using System.Collections.Specialized;

namespace VirtualRestaurant;

public class Order
{ 
    Customer customer;
    public string dish;
    public double price { get; set; }
    public int amount { get; set; }

    public Order(Customer customer, string dish, double price, int amount)
    {
        this.customer = customer;
        this.dish = dish;
        this.price = price;
        this.amount = amount;
    }
}