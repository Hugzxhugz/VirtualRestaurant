using System.Collections.Specialized;

namespace VirtualRestaurant;

public class Order
{
    public Customer customer;
    public object dish;
    public decimal price { get; set; }
    public int amount { get; set; }

    
    public Order(object dish, decimal price, int amount)
    {
        
        this.dish = dish;
        this.price = price;
        this.amount = amount;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Dish name: {dish}, Price: {price}, Amount: {amount}");
    }
}