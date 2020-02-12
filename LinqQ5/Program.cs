using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQ5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 3, 6, 10, 12, 8 };

            var query1 = numbers.OrderByDescending(n => n);

            //Console.WriteLine("Before the foreach loop");

            var query2 = query1.Where(n => n < 8);

            var query3 = query2.Select(n => DoubleIt(n));


            // query 4 will give the same result as query 3, as it effectively chaines them all into one
            var query4 = numbers.OrderByDescending(n => n).Where(n => n < 8).Select(n => DoubleIt(n)); 

            //foreach (var item in query1)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in query2)
            //{
            //    Console.WriteLine(item);
            //}

            foreach (var item in query3)
            {
                Console.WriteLine(item);
            }


            foreach (var item in query4)
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
