namespace VirtualRestaurant;

public class Customer
{
    public string Name { get; set; }
    public int PhoneNumber { get; set; }
    public string Email { get; set; }
    public string DeliveryAddress { get; set; }
    public bool DineIn;

    public Customer(string name, int phoneNumber, string email, string deliveryAddress, bool dineIn)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
        DeliveryAddress = deliveryAddress;
        DineIn = dineIn;
    }
}