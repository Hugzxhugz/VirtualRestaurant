namespace VirtualRestaurant;

public class MenuCreator
{
    public Dictionary<string, decimal> Menu { get; set; }


    public MenuCreator()
    {
        Menu = new Dictionary<string, decimal>();

        Sandwich Cheeseburger = new Cheeseburger();
        Sandwich GrilledChicken = new GrilledChicken();
        
        AddSandwichToMenu(Cheeseburger);
        AddSandwichToMenu(GrilledChicken);


    }

    public void AddSandwichToMenu(Sandwich sandwich)
    {
        if (!Menu.ContainsKey(sandwich.name))
        {
            Menu.Add(sandwich.name, sandwich.price);
        }
        else
        {
            Console.WriteLine("Specified sandwich is already in the menu");
        }
        
    }

    public Dictionary<string, decimal> SetMenuToRestaurant(Restaurant restaurant)
    {
        restaurant.menu = Menu;
        return Menu;
    }
    
    
    
    
    
    
}