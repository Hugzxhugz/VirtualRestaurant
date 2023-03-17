namespace VirtualRestaurant;

public class Restaurant
{
    public Dictionary<string, decimal> menu { get; set; }
    public List<Order> ordersList { get; set; }
    public MenuCreator MenuCreator;
    
    
    public Restaurant()
    {
        MenuCreator = new MenuCreator();
        this.menu = MenuCreator.SetMenuToRestaurant(this);
        this.ordersList = ordersList;
        
        
    }


    public void TakeOrder(Customer customer, string dish, int amount)
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
        payment.ProcessPayment(this, payment);
        handler.HandleOrder(order);
        ordersList.Remove(order);
        Console.WriteLine("Order released.");
    }
}