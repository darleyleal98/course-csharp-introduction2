using Course.Entities;
using Course.Entities.Enums;
using System;

namespace Course
{
    public class Program
    {
        static void Main()
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

            string text = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(text);
            Console.WriteLine(os);
        }
    }
}