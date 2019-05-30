using System;
using ExEnums.Entities;
using ExEnums.Entities.Enums;

namespace ExEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order{
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            System.Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            System.Console.WriteLine(os);
            System.Console.WriteLine(txt);
        }
    }
}
