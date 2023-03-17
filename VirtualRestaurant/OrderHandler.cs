namespace VirtualRestaurant;

public class OrderHandler
{
    public void HandleOrder(Order order)
    {
        if (order.customer.DineIn.Equals(true) && order.customer.Deliver.Equals(false))
        {
            Console.WriteLine("Order served to diner.");
        }
        else if (order.customer.Deliver.Equals(true) &&order.customer.DineIn.Equals(false))
        {
            Console.WriteLine($"Order will be now be delivered to {order.customer.DeliveryAddress}");
        }
        else
        {
            Console.WriteLine("\nPreparing order for take-away.");
        }
        
    }
}