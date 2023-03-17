namespace VirtualRestaurant;

public class GrilledChicken : Sandwich
{
    public GrilledChicken(string name, int price) : base(name, price)
    {
        this.name = "Grilled Chicken Sandwich";
        this.price = 50.0m;
        this.addons = addons;
        this.description = "Marinated chicken fillet, grilled to perfection.";
    }
}