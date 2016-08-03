using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Parallel.For_Loop_with_Thread_Local_Variables
{
    class Program
    {
        static void Main()
        {
            int[] nums = Enumerable.Range(0, 1000000).ToArray();
            long total = 0;

            System.Threading.Tasks.Parallel.For<long>(0, nums.Length, () => 0, (j, loop, subtotal) =>
               {
                   subtotal += nums[j];
                   return subtotal;
               },
                (x) => Interlocked.Add(ref total, x)
            );

            Console.WriteLine("The total is {0:N0}", total);
            Console.WriteLine("Press any key to Exit");
            Console.ReadKey();
        }
    }
}
