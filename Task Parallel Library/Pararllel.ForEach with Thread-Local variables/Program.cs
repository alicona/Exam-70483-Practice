using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Pararllel.ForEach_with_Thread_Local_variables
{
    class Program
    {
        static void Main()
        {
            int[] nums = Enumerable.Range(0, 1000000).ToArray();
            long total = 0;

            Parallel.ForEach<int, long>(nums,
                                                            ()=>0,
                                                            (j, loop,subtotal)=>
                                                            {
                                                                subtotal += j;
                                                                return subtotal;
                                                            },
                                                            (finalResult)=>Interlocked.Add(ref total, finalResult)
                                        );
            Console.WriteLine("The total from Parallel.ForEach is {0:N0}", total);
            Console.ReadKey();
        }
    }
}
