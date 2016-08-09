using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = {
                new Person { FirstName="Damon", LastName="Hill" },
                new Person { FirstName="Niki", LastName="Lauda" },
                new Person { FirstName="Ayrton", LastName="Senna" },
                new Person { FirstName="Graham", LastName="Hill" }
            };

            Array.Sort(persons);
            foreach (var p in persons)
            {
                Console.WriteLine(String.Format("{0} {1}", p.FirstName, p.LastName));
            }
            Console.ReadKey();

        }

        
    }
}
