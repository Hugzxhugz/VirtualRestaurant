namespace VirtualRestaurant;

public class Restaurant
{
    public Dictionary<object, decimal> menu { get; set; }
    public List<Order> ordersList { get; set; }
    
    
    public Restaurant()
    {
        this.menu = menu;
        this.ordersList = ordersList;
    }


    public void TakeOrder(Customer customer, object dish, int amount)
    {
        if (!menu.ContainsKey(dish))
        {
            Console.WriteLine("Dish is not available.");
        }
        else
        {
            decimal price = menu[dish];
            Order order = new Order(customer, dish, price, amount);
            ordersList.Add(order);
            Console.WriteLine("Successfully taken order.");
        }
    }
    
    public void ReleaseOrder(Order order,OrderHandler handler, Payment payment) 
    {
        handler.HandleOrder(order);
        payment.ProcessPayment(order, payment);
        ordersList.Remove(order);
        Console.WriteLine("Order released.");
    }
}