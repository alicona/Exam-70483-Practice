using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingWeakReference
{
    class Program
    {
        static void Main(string[] args)
        {
            int cacheSize = 50;
            Random r = new Random();
            Cache c = new Cache(cacheSize);

            string DataName = "";
            GC.Collect(0);

            //Randomly access object from cache.
            for (int i = 0; i < c.Count; i++)
            {
                int index = r.Next(c.Count);

                //acces the object by getting a property value
                DataName = c[index].Name;
            }

            double regenPorcent = c.RegenerationCount/(double) c.Count;
            Console.WriteLine("Cache Size: {0}, Regenerated {1:P2}%", c.Count, regenPorcent);
            Console.ReadKey();
        }

        protected 
    }
}
