namespace VirtualRestaurant;

public class RestaurantMenu
{
    Restaurant restaurant = new Restaurant();
    Customer customer;
    Payment payment;
    PrintClass printClass;
    MenuCreator menuCreator;

    public void MainMenu()
    {
        var running = true;
        Console.WriteLine("Do you want to Login as customer or restaurant owner");
        var role = Console.ReadLine().ToLower().ToLower();
        
        while (running)
        {
            if (role == "customer")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Fill up delivery information");
                Console.WriteLine("2. Make order");
                Console.WriteLine("3. Complete payment");
                Console.WriteLine("4. Print receipt");
                Console.WriteLine("5. Quit");

                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        customer = FillCustomerInfo();
                        break;
                    case "2":
                        MakeOrder();
                        break;
                    case "3":
                        CompletePayment();
                        return;
                    case "4":
                        PrintReceipt();
                        break;
                    case "5":
                        running = false;
                        Console.WriteLine("Welcome again!");
                        break;
                    default:
                        Console.WriteLine("Not applicable option.");
                        break;
                }
            }

            else if (role == "owner")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Handle orders");
                Console.WriteLine("2. Get today's sales");
                Console.WriteLine("3. Quit");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        HandleOrder();
                        break;
                    case "2":
                        PrintSales();
                        break;
                    case "3":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Not applicable option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid login. Please try again.");
                MainMenu();
            }
        }
    }

    private void PrintSales()
    {
        if (!restaurant.dailyOrders.Any())
        {
            Console.WriteLine("There were no sales today.");
        }
        else
        {
            printClass.PrintTotalSales();
        }
    }

    private void HandleOrder()
    {
        if (!restaurant.ordersList.Any())
        {
            Console.WriteLine("There is no ongoing order.");
        }
        else
        {
            OrderHandler handler = new OrderHandler();
            foreach (var order in restaurant.ordersList)
            {
                restaurant.ReleaseOrder(customer, order, handler, payment);
            }
        }
    }

    private void PrintReceipt()
    {
        if (customer == null || restaurant.ordersList.Count == 0)
        {
            Console.WriteLine("Please fill in your information or make order first.");
        }
        else
        {
            printClass.PrintReceipt(customer);
        }
    }

    private void CompletePayment()
    {
        Console.WriteLine("What's your card type? ");
        var cardType = Console.ReadLine();
        Console.WriteLine("What's your card number? ");
        var cardNumber = Console.ReadLine();
        Console.WriteLine("Do you want to pay with card? Y/N");
        var output = Console.ReadLine();
        bool ifCash = output.ToLower() == "n";
        payment = new Payment(cardType, cardNumber, ifCash);
        payment.ProcessPayment(restaurant, payment);
    }

    private void MakeOrder()
    {
        if (customer == null)
        {
            Console.WriteLine("Please fill in your delivery information first.");
        }
        else
        {
            restaurant.PrintMenu();
            Console.WriteLine("What do you want to order?");
            var dish = Console.ReadLine().ToLower();
            Console.WriteLine($"How many {dish} do you want?");
            var amount = Int32.Parse(Console.ReadLine());
            restaurant.TakeOrder(customer, dish, amount);
        }
    }

    private Customer FillCustomerInfo() 
    {
        Console.WriteLine("What's your name? ");
        var name = Console.ReadLine();
        Console.WriteLine("What's your phone number? ");
        var phoneNumber = Console.ReadLine();
        Console.WriteLine("What's your email? ");
        var email = Console.ReadLine();
        Console.WriteLine("What's your delivery address? ");
        var deliveryAddress = Console.ReadLine();
        Console.WriteLine("Do you want to dine in? Y/N "); // needs functionality
        var output = Console.ReadLine(); //if n ask for takeout or deliver
        var dineIn = true;
        var delivery = false;
        if (output.ToLower() == "n")
        {
            dineIn = false;
            delivery = true;
        }

        return new Customer(name, phoneNumber, email, deliveryAddress, dineIn, delivery);
    }
}