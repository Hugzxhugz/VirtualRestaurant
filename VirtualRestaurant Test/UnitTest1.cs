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
    
    
    
    
}