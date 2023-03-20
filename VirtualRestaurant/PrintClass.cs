namespace VirtualRestaurant;

public class PrintClass
{
    Restaurant restaurant;
    Payment payment;
    public decimal totalSales;
    
    public void PrintReceipt(Customer customer)
    {
        Console.WriteLine($"--- Order Receipt ---");
        Console.WriteLine($"Buyer Name: {customer.Name}, E-mail: {customer.Email}");
        foreach (var order in restaurant.ordersList)
        {
            order.PrintInfo();
        }
        Console.WriteLine($"Total amount: {payment.totalAmount}");
    }

    public void PrintTotalSales()
    {
        Console.WriteLine($"Today's total orders are {restaurant.dailyOrders.Count}.");
        foreach (var order in restaurant.dailyOrders)
        {
            totalSales += order.price * order.amount;
        }
        Console.WriteLine($"Today's total sales are {totalSales}");
    }
}