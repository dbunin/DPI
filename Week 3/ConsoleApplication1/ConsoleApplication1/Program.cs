using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rest = Convert.ToInt32(Console.ReadLine());
            int nrOfCoins = rest/50;

            Console.WriteLine("50 cents: " + nrOfCoins);
            rest = rest % 50;

            nrOfCoins = rest / 20;
            Console.WriteLine("20 cents: " + nrOfCoins);
            rest = rest % 20;

            nrOfCoins = rest / 10;
            Console.WriteLine("10 cents: " + nrOfCoins);
            rest = rest % 10;

            nrOfCoins = rest / 5;
            Console.WriteLine("5 cents: " + nrOfCoins);
            rest = rest % 5;

            nrOfCoins = rest / 2;
            Console.WriteLine("2 cents: " + nrOfCoins);
            rest = rest % 2;

            nrOfCoins = rest / 1;
            Console.WriteLine("1 cents: " + nrOfCoins);
            Console.Read();
        }
    }
}
