using System;
using Ship;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shipping shipping =new Shipping();
            Console.WriteLine(shipping.CalculatePackages(16, 3, 10));


        }
    }
}
