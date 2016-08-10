using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedCasts
{
    class Program
    {
        static void Main(string[] args)
        {
            UserDefinedCasts();
            Console.ReadKey();
        }

        static void  UserDefinedCasts()
        {
            try
            {
                Currency balance = new Currency(50,35);

                Console.WriteLine(balance);
                Console.WriteLine("balance is " + balance);
                Console.WriteLine("balance is (using ToString()) " + balance.ToString());

                float balance2 = balance;

                Console.WriteLine("After converting to float, = " + balance2);

                balance = (Currency) balance2;

                Console.WriteLine("After converting back to Currency, = " + balance);
                Console.WriteLine("Now attempt to convert out of range value of " +
                                  "-$50.50 to a Currency:");

                checked
                {
                    balance = (Currency) (-50.50);
                    Console.WriteLine("Result is " + balance.ToString());
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("Exception occurred: " + e.Message);
            }
        }
    }
}
