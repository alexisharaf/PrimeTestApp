using System;
using System.Threading.Tasks;

namespace PrimeTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime starttime, endtime;
            bool isprime = false;

            Console.WriteLine("Hello World!");

            starttime = DateTime.Now;

           //for (int i = 2; i < 1000000; i++)

            Parallel.For(2, 1000000, i =>
            {
                isprime = true;
                for (int j = 2; j < i; j++)
                {
                    if ((i % j) == 0)
                    {
                        isprime = false;
                        break;
                    }


                }

                if (isprime)
                {
                    Console.WriteLine(i);
                }
            }
           );

            endtime = DateTime.Now;

            Console.WriteLine(endtime - starttime);
            Console.Read();
        }
    }
}
