namespace VirtualRestaurant;

public class Order
{ 
    Customer customer;
    List<Dish> dishList;
    public double price { get; set; }
    public int amount { get; set; }

    public Order(Customer customer, List<Dish> dishList, double price, int amount)
    {
        this.customer = customer;
        this.dishList = dishList;
        this.price = price;
        this.amount = amount;
    }
}