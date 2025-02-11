using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class Program4
    {
        public static async Task ProcessOrder()
        {
            Console.WriteLine("Enter your order name");
            string orderName = Console.ReadLine();
            Console.WriteLine("Processing order...");
            await Task.Delay(3000);
            Console.WriteLine($"Your order for {orderName} is ready!!");
        }
        
        public static async Task Main(string[] args)
        {
            await ProcessOrder();

        }
    }

}
