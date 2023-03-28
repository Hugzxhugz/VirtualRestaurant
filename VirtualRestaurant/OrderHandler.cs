namespace VirtualRestaurant;

public class OrderHandler
{
    
    public void HandleOrder(Customer customer, Order order)
    {
        if (customer.DineIn.Equals(true) && customer.Deliver.Equals(false))
        {
            Console.WriteLine("Order served to diner.");
        }
        else if (customer.Deliver.Equals(true) && customer.DineIn.Equals(false))
        {
            Console.WriteLine($"Order will be now be delivered to {customer.DeliveryAddress}.");
        }
        else
        {
            Console.WriteLine("\nPreparing order for take-away.");
        }
        
    }
}