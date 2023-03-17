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

    public void ProcessPayment()
    {
        
    }
}