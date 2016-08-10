using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterateThroughCollections
{
    public class Program
    {
        static void Main(string[] args)
        {
            Method1();
            Console.ReadKey();
        }

        static void Method1()
        {
            Console.WriteLine("Different Ways to Iterate Through Collections");
            var titles = new MusicTitles();
            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }
            Console.WriteLine();

            Console.WriteLine("reverse");
            foreach (var title in titles.Reverse())
            {
                Console.WriteLine(title);
            }
            Console.WriteLine();

            Console.WriteLine("subset");
            foreach (var title in titles.Subset(2, 2))
            {
                Console.WriteLine(title);
            }
        }
    }

    
}
