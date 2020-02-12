using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQ6to8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Mary", "Joseph", "Michael", "Sarah", "Margaret", "John" };



            //output the array to screen 
            var query = names.Select(n => n);

            foreach (var name in query)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            //output the array to screen and use order by descending and then reverse it to put it in alphabetical order 
            var queryAlphabetical = names.OrderByDescending(n => n).Reverse();

            foreach (var name in queryAlphabetical)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            //output only the names beginning with M
            var queryM = names.Where(n => n.StartsWith("M"));
           
            foreach (var name in queryM)
            {
                Console.WriteLine(name);
            }

        }
    }
}
