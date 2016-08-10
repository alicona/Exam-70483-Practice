using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            var hello = new HelloCollection();

            foreach (var h in hello)
            {
                Console.WriteLine(h);
            }

            Console.ReadKey();
        }


    }
}
