using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 3, 6, 10, 12, 8 };

            var query = numbers.Select(n => DoubleIt(n));

            Console.WriteLine("Before the foreach loop");

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        private static int DoubleIt(int value)
        {
            Console.WriteLine("About to double the number " + value.ToString());
            return value * 2;
        }
    }
}
