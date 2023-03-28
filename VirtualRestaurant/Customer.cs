namespace VirtualRestaurant;

public class Customer
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public List<Order> OrderList;
    public string DeliveryAddress { get; set; }
    public bool DineIn;
    public bool Deliver;

    public Customer(string name, string phoneNumber, string email, string deliveryAddress, bool dineIn, bool deliver)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
        OrderList = new List<Order>();
        DeliveryAddress = deliveryAddress;
        DineIn = dineIn;
        Deliver = deliver;
    }

    public void addToOrders(Order order)
    {
        OrderList.Add(order);
    }
}