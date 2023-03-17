namespace VirtualRestaurant;

public class Restaurant
{
    public Dictionary<string, decimal> Menu { get; set; }
    public List<String> ordersList { get; set; }
    
    
    public Restaurant(Dictionary<string, decimal> menu, List<string> ordersList)
    {
        Menu = menu;
        this.ordersList = ordersList;
    }


    public void TakeOrder()
    {
        
    }
    
    public void ReleaseOrder()
    {
        
    }
}