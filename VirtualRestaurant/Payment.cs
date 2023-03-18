namespace VirtualRestaurant;

public class Payment
{
    public string cardType { get; set; }
    public string cardNumber { get; set; }
    public bool ifCash { get; set; }

    public Payment(string cardType, string cardNumber, bool ifCash)
    {
        this.cardType = cardType;
        this.cardNumber = cardNumber;
        this.ifCash = ifCash;
    }

    public void ProcessPayment(Restaurant restaurant, Payment payment)
    {
        decimal totalAmount = 0.00m;

        foreach (Order order in restaurant.ordersList)
        {
            totalAmount += order.amount * order.price;
        }
        
        
        if (ifCash.Equals(true))
        {
            Console.WriteLine($"Total amount: {totalAmount}");
            Console.Write("Cash payment: ");
            decimal cashPayment = decimal.Parse(Console.ReadLine());

            IfCashPayment(cashPayment, totalAmount);
        }
        else if (ifCash.Equals(false))
        {
            if (cardType == null || cardNumber == null)
            {
                Console.WriteLine("No credit card information found.");
            }
            else
            {
                Console.WriteLine($"Total amount: {totalAmount} \nPayment from credit card recieved.");
            }
        }
        else
        {
            Console.WriteLine("We only accept cash or credit payments.");
        }
    }

    public void IfCashPayment(decimal cashPayment, decimal totalAmount)
    {
        if (cashPayment > totalAmount)
        {
            Console.WriteLine($"Your change: {cashPayment - totalAmount}");
        }
        else if (cashPayment == totalAmount)
        {
            Console.WriteLine("Thank you for paying exact amount.");
        }
        else
        {
            Console.WriteLine("Insufficient payment.");
        }
    }
}