using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesLambdasAndEvents
{
    class Program
    {

        enum color
        {
            red,
            green,
            blue
        }

        
        static void Main(string[] args)
        {
            int x = 40;
            GetAString firstStringMethod = x.ToString;
            Console.WriteLine("String is {0}", firstStringMethod());

            Currency balance = new Currency(34,50);

            firstStringMethod = balance.ToString;
            Console.WriteLine("String is {0}", firstStringMethod());

            firstStringMethod = new GetAString(Currency.GetCurrencyUnit);
            Console.WriteLine("String is {0}", firstStringMethod());
            Single j = 5.4f;
            Console.WriteLine(j);

            char ch = Convert.ToChar('a' | 'b' | 'c');
            Console.WriteLine(ch);

            Console.ReadKey();
            

        }

        public delegate string GetAString();
    }
}
