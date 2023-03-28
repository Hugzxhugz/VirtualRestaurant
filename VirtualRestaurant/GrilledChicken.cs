namespace VirtualRestaurant;

public class GrilledChicken : Sandwich
{
    public GrilledChicken() : base("grilled chicken", 45.99m)
    {
       
        this.addons = addons;
        this.description = "Lemon-herb and barbecue marinated chicken fillet, grilled to perfection.";
    }
}