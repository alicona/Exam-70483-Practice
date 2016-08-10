using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Divide(5, 2);
            Console.WriteLine("Result of Division: {0}, reminder: {1}", result.Item1, result.Item2);
            Console.ReadKey();
        }

        public static Tuple<int, int> Divide(int divident, int divisor)
        {
            int result = divident/divisor;
            int reminder = divident%divisor;

            return Tuple.Create<int, int>(result, reminder);
        }
    }
}
