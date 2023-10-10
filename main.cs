class Program
{
    static void Main(string[] args)
    {
        OrderManagementSystem system = new OrderManagementSystem();

        // Addition of example orders
        system.PlaceOrder(1, "Jan Kowalski");
        system.PlaceOrder(2, "Anna Nowak");

        while (true)
        {
            Console.WriteLine("1. Add order");
            Console.WriteLine("2. Cancel order");
            Console.WriteLine("3. Display all orders");
            Console.WriteLine("4. Display the number of all orders");
            Console.WriteLine("5. Exit");

            string option = Console.ReadLine();

            try
            {
                switch (option)
                {
                    case "1":
                        Console.Write("Enter order id: ");
                        int orderId = int.Parse(Console.ReadLine());
                        Console.Write("Specify the client's name: ");
                        string customerName = Console.ReadLine();

                        if (system.PlaceOrder(orderId, customerName))
                        {
                            Console.WriteLine($"Order added: {orderId} for the client: {customerName}");
                        }
                        else
                        {
                            Console.WriteLine("An order with the specified ID already exists. Try again with a different ID.");
                        }
                        break;

                    case "2":
                        Console.Write("Enter the order id to be cancelled: ");
                        orderId = int.Parse(Console.ReadLine());
                        system.CancelOrder(orderId);
                        Console.WriteLine("Order cancelled.");
                        break;

                    case "3":
                        system.DisplayOrders();
                        break;

                    case "4":
                        Console.WriteLine($"The number of total orders: {system.TotalOrders()}");
                        break;

                    case "5":
                        return;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }
    }
}

