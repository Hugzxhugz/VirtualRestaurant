namespace VirtualRestaurant;

public class Restaurant
{
    public Dictionary<string, (decimal,string)> menu { get; set; }
    public List<Order> ordersList { get; set; }
    public MenuCreator MenuCreator;
    
    
    public Restaurant()
    {
        MenuCreator = new MenuCreator();
        this.menu = MenuCreator.SetMenuToRestaurant(this);
        this.ordersList = new List<Order>();
    }


    public void TakeOrder(Customer customer, string dish, int amount)
    {
        if (!menu.ContainsKey(dish))
        {
            Console.WriteLine("Dish is not available.");
        }
        else
        {
            var item = menu[dish];
            decimal price = item.Item1;
            Order order = new Order(customer, dish, price, amount);
            ordersList.Add(order);
            Console.WriteLine("Successfully taken order.");
        }
    }
    
    public void ReleaseOrder(Order order,OrderHandler handler, Payment payment) 
    {
        handler.HandleOrder(order);
        
        Console.WriteLine("Customer's order:");
        Console.WriteLine($"{order.dish} x {order.amount} (${order.amount * order.price})");
        Console.WriteLine("Order released.");
    }
    
    public void PrintMenu()
    {
        Console.WriteLine("Restaurant Menu:");
        foreach (var menuItem in menu)
        {
            Console.WriteLine($"{menuItem.Key} - Price: {menuItem.Value.Item1} \n -- {menuItem.Value.Item2}\n");
        }
    }
    
    
}