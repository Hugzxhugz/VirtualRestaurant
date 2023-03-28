namespace VirtualRestaurant;

public class Cheeseburger : Sandwich
{
    public Cheeseburger() : base("cheeseburger", 54.99m)
    {
        this.addons = addons;
        this.description = "Our quarter-pounder, 100% pure-beef burger with smoked gouda cheese.";
    }
}