namespace VirtualRestaurant;

public class TestSandwich : Sandwich
{
    public TestSandwich() : base("test sandwich", 10.00m)
    {
        description = "This is a test sandwich.";
    }
}