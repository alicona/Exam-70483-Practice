using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Example example = new Example(new string[] {"cat", "dog", "bird"});

            foreach (var element in example)
            {
                Console.WriteLine( element);
            }

            Console.ReadKey();
        }
    }
}
