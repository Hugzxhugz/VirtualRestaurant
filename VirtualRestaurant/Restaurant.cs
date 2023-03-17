namespace VirtualRestaurant;

public class Restaurant
{
    public Dictionary<string, decimal> Menu;
    public List<String> ordersList;
    
    
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