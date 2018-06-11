using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderService = new OrderService();
            var result = orderService.CalculatePrice(price => price > 1000.0);
            
            Console.WriteLine($"Discount Price:{result}");
        }
    }
}