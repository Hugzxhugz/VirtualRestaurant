namespace VirtualRestaurant;

public class TestSandwich : Sandwich
{
    public TestSandwich() : base("Test Sandwich", 10.00m)
    {
        description = "This is a test sandwich.";
    }
}