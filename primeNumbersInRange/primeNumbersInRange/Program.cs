using System;

namespace primeNumbersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindPrimeNumbersInRange();
        }

        public static void FindPrimeNumbersInRange()
        {
            bool flag = true;
            for (int i = 2; i < 1000; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    double rem = i % j;
                    if (rem == 0)
                    {
                        flag = true;
                        break;

                    }

                    else
                    {
                        flag = false;
                    }
                }

                if (flag==true)

                {
                    Console.WriteLine(i + "is not a prime nmber");
                }
                else
                {
                    Console.WriteLine(i + "is a prime number");
                }




            }
        }
    }
}
