using System.Text;
using VirtualRestaurant;

namespace VirtualRestaurant_Test;

public class RestaurantTest
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
    }

    [Fact]
    public void WhenDishNotAvailableOrderIsPlaced_shouldBeNotBeFound()
    {
        Restaurant restaurant = new Restaurant();
        Customer customer = new Customer("James", "12345", "james@email.com", "home", false, false);
        string dish = "Pizza";
        int amount = 2;
        
        restaurant.TakeOrder(customer, dish, amount);

        Assert.DoesNotContain(restaurant.ordersList, o => o.dish == dish);
    }
    
    [Fact]
    public void WhenDishAvailable_ShouldAddOrderToList()
    {
        Restaurant restaurant = new Restaurant();
        Customer customer = new Customer("James", "12345", "james@email.com", "home", false, false);
        string dish = "Cheeseburger";
        int amount = 1;

        restaurant.TakeOrder(customer, dish, amount);

        Order order = restaurant.ordersList.First();
        Assert.Equal(customer, order.customer);
        Assert.Equal(dish, order.dish);
        Assert.Equal(54.99m, order.price);
        Assert.Equal(amount, order.amount);
    }
    
    [Fact]
    public void ReleaseOrder_ShouldAddOrderToDailyOrdersAndRemoveFromOrdersList()
    {
        Restaurant restaurant = new Restaurant();
        OrderHandler orderHandler = new OrderHandler();
        Customer customer = new Customer("James", "12345", "james@email.com", "home", false, false);
        Sandwich cheeseburger = new Cheeseburger();
        string dish = "Cheeseburger";
        int amount = 1;
        Order order = new Order(customer, "Cheeseburger", cheeseburger.price, 1);
        Payment payment = new Payment("Visa", "54321", false);

        restaurant.ReleaseOrder(order,orderHandler, payment);

        Assert.Contains(order, restaurant.dailyOrders);
        Assert.DoesNotContain(order, restaurant.ordersList);
    }

    [Fact]
    public void TestToCheckIfOrderIsDefinitelyAddedToDailyOrdersAfterReleaseOrder()
    {
        Restaurant restaurant = new Restaurant();
        OrderHandler orderHandler = new OrderHandler();
        Customer customer = new Customer("James", "12345", "james@email.com", "home", false, false);
        Sandwich grilledChicken = new GrilledChicken();
        string dish = "Grilled Chicken";
        int amount = 1;
        Order order = new Order(customer, dish, grilledChicken.price, 1);
        Payment payment = new Payment("Visa", "54321", false);

        restaurant.ReleaseOrder(order,orderHandler, payment);

        Order oldOrder = restaurant.dailyOrders.First();
        Assert.Equal(customer, order.customer);
        Assert.Equal(dish, order.dish);
        Assert.Equal(45.99m, order.price);
        Assert.Equal(amount, order.amount);
    }
    
    [Fact]
    public void PrintMenu_ShouldWriteExpectedOutputToConsole()
    {
        var restaurant = new Restaurant();
        StringBuilder consoleOutput = new StringBuilder();
        Console.SetOut(new StringWriter(consoleOutput));

        string expectedOutput =
            "Restaurant Menu:\r\nCheeseburger - Price: 54.99 \n -- Our quarter-pounder, 100% pure-beef burger with smoked gouda cheese.\n\r\nGrilled Chicken - Price: 45.99 \n -- Lemon-herb and barbecue marinated chicken fillet, grilled to perfection.\n\r\n";

        restaurant.PrintMenu();

        Assert.Equal(expectedOutput, consoleOutput.ToString());
    }
}