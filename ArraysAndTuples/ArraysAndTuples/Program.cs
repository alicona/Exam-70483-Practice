using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndTuples
{
    class Program
    {
        static Person[] persons = {
                new Person { FirstName="Damon", LastName="Hill" },
                new Person { FirstName="Niki", LastName="Lauda" },
                new Person { FirstName="Ayrton", LastName="Senna" },
                new Person { FirstName="Graham", LastName="Hill" }
            };

        static void Main(string[] args)
        {
            
            UsingIComparable();
            UsingIComparer();
            Console.ReadKey();

        }

        static void UsingIComparable() {
            Console.WriteLine("IComparable\n");
            Array.Sort(persons);
            foreach (var p in persons)
            {
                Console.WriteLine(String.Format("{0} {1}", p.FirstName, p.LastName));
            }
        }

        static void UsingIComparer() {
            Console.WriteLine("IComparer\n");
            Array.Sort(persons, new PersonComparer(PersonCompareType.FirstName));

            foreach (var p in persons)
            {
                Console.WriteLine(String.Format("{0} {1}", p.FirstName, p.LastName));
            }
        }
        
    }
}
