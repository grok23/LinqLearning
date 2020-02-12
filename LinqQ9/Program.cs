using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQ9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Customer> customers = GetCustomers();

            //Create a LINQ query which extracts customer names where the City is Dublin
            var query = customers.Where(n => n.City == "Dublin");

            Console.WriteLine("Dubliners");
            foreach (var customer in query)
            {
                Console.WriteLine(customer);
            }

            //Create a LINQ query which extracts customer names where the City is Dublin or Galway
            var queryOr = customers.Where(n => n.City == "Dublin" || n.City == "Galway");

            Console.WriteLine("\nDublin & Galway");
            foreach (var customer in queryOr)
            {
                Console.WriteLine(customer);
            }

            //Create a LINQ query which extracts customer names where the City is Dublin or Galway and order by name
            var queryAlpha = customers.Where(n => n.City == "Dublin" || n.City == "Galway").OrderByDescending(n => n.Name).Reverse();

            Console.WriteLine("\nDublin & Galway customers in Alphabetical order");
            foreach (var customer in queryAlpha)
            {
                Console.WriteLine(customer);
            }
        }
        private static List<Customer> GetCustomers()
        {
            Customer c1 = new Customer { Name = "Tom", City = "Dublin" };
            Customer c2 = new Customer { Name = "Sally", City = "Galway" };
            Customer c3 = new Customer { Name = "George", City = "Cork" };
            Customer c4 = new Customer { Name = "Molly", City = "Dublin" };
            Customer c5 = new Customer { Name = "Joe", City = "Galway" };

            List<Customer> customers = new List<Customer>();
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);
            customers.Add(c4);
            customers.Add(c5);

            return customers;
        }

        public class Customer
        {
            public string Name;
            public string City;

            public override string ToString()
            {
                return string.Format(Name);
            }
        }
    }
}
