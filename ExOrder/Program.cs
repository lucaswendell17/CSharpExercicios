using System;
using System.Globalization;
using ExOrder.Entities;
using ExOrder.Entities.Enums;

namespace ExOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter cliente data: ");
            System.Console.Write("Name: ");
            string name = Console.ReadLine();
            System.Console.Write("Email: ");
            string email = Console.ReadLine();
            System.Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter order data:");
            System.Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            System.Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                System.Console.WriteLine($"Enter #{i} item data:");
                System.Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                System.Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                System.Console.Write("Quantity: ");
                int qtd = int.Parse(Console.ReadLine());
                Product product = new Product(prodName, price);
                OrderItem orderItem = new OrderItem(qtd, price, product);
                order.AddItem(orderItem);
            }
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine(order);
        }
    }
}
