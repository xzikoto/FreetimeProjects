using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter first number");
                Console.Write("num:");
                int numone = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter symbol");
                Console.Write("sym:");
                char charone = char.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number");
                Console.Write("num:");
                int numtwo = int.Parse(Console.ReadLine());

                if (charone == '*')
                {
                    Console.WriteLine(numone * numtwo);
                }
                else if (charone == '/')
                {
                    Console.WriteLine(numone / numtwo);
                }
                else if (charone == '+')
                {
                    Console.WriteLine(numone + numtwo);
                }

                else if (charone == '-')
                {
                    Console.WriteLine(numtwo - numtwo);
                }


            }
        }
    }
}
