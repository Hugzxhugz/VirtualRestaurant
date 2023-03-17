namespace VirtualRestaurant;

public class Cheeseburger : Sandwich
{
    public Cheeseburger(string name, int price) : base(name, price)
    {
        this.name = "Cheeseburger";
        this.price = 50.0m;
        this.addons = addons;
        this.description = "Our quarter-pounder, 100% pure-beef burger";
    }
}