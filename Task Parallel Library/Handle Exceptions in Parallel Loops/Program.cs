using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handle_Exceptions_in_Parallel_Loops
{
    class Program
    {
        static void Main()
        {
            byte[] data = new byte[5000];
            Random r = new Random();

            r.NextBytes(data);

            try
            {
                ProcessDataInParallel(data);
            }
            catch (AggregateException ae)
            {

                foreach (var ex in ae.InnerExceptions)
                {
                    if (ex is ArgumentException)
                        Console.WriteLine(ex.Message);
                    else
                        throw ex;
                }
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private static void ProcessDataInParallel(byte[] data) {
            var exceptions = new ConcurrentQueue<Exception>();

            Parallel.ForEach(data, d=>
            {
                try
                {
                    if (d < 0x3)
                        throw new ArgumentException(String.Format("Value is {0:x}. Elements must be creater than 0x03", d));
                    else
                        Console.Write(d + " ");
                }
                catch (Exception e )
                {

                    exceptions.Enqueue(e);
                }
            });

            if (exceptions.Count > 0) throw new AggregateException(exceptions);
        }
    }
}
