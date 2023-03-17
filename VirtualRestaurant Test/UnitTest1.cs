using VirtualRestaurant;

namespace VirtualRestaurant_Test;

public class UnitTest1
{
    [Fact]
    public void TestMenuCreatorContainsSandwiches()
    {
        MenuCreator menuCreator = new MenuCreator();

        Assert.True(menuCreator.Menu.ContainsKey("Cheeseburger"));
        Assert.True(menuCreator.Menu.ContainsKey("Grilled Chicken"));
    }
    
    [Fact]
    public void TestAddSandwichToMenuContainsTestSandwich()
    {
        MenuCreator menuCreator = new MenuCreator();
        

        Assert.True(menuCreator.Menu.ContainsKey("Cheeseburger"));
        Assert.True(menuCreator.Menu.ContainsKey("Grilled Chicken"));
        
        Sandwich testsandwich = new TestSandwich();
        menuCreator.AddSandwichToMenu(testsandwich);
        Assert.True(menuCreator.Menu.ContainsKey("Test Sandwich"));
    }
    
    [Fact]
    public void TestAddSandwichToRestaurantMenuContainsTestSandwich()
    {
        // Create a new restaurant
        Restaurant restaurant = new Restaurant();
            
        // Set testsandwich to restaurant menu

        MenuCreator menuCreator = new MenuCreator();
        Sandwich testsandwich = new TestSandwich();
        menuCreator.AddSandwichToMenu(testsandwich);
        menuCreator.SetMenuToRestaurant(restaurant);
        
        Assert.True(menuCreator.Menu.ContainsKey("Test Sandwich"));
            
        /* Print the restaurant's menu
        Console.WriteLine("Restaurant Menu:");
        foreach (var menuItem in restaurant.menu)
        {
            Console.WriteLine($"{menuItem.Key} - Price: {menuItem.Value}");
        }*/
    }
    
    
    
    
}