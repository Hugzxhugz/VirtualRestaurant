namespace VirtualRestaurant;

public abstract class Sandwich
{
    public string name { get; set; }
    public string description { get; set; }
    public List<String> addons { get; set; }
    public decimal price { get; set; }
    
    public Sandwich(string name, decimal price)
    {
        this.name = name;
        this.description = description;
        this.addons = addons;
        this.price = price;
    }

   
}