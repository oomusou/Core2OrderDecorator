using System;
using OrderLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderService = new OrderService();
            var originalPrice = 1200;
            var realPrice = orderService.GetPrice(originalPrice);
            Console.WriteLine("Original price:{0}, Real price:{1}", originalPrice, realPrice);

            originalPrice = 800;
            realPrice = orderService.GetPrice(originalPrice);
            Console.WriteLine("Original price:{0}, Real price:{1}", originalPrice, realPrice);
        }
    }
}