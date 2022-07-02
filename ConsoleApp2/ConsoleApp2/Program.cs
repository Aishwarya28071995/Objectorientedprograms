using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindPrimeNumbers();
        }

        public static void FindPrimeNumbers()
        {
            bool flag = true;
            for(int i=0;i<1000;i++)
            {
                for(int j=2;i<1000;j++)
                {
                    if(i!=j && i!=0)
                    {
                        if(i%j==0)
                        {
                            flag = true;
                        }
                    }

                    else
                    {
                        flag = false;
                    }
                }
            }

            if(flag ==true)
            {
                Console.WriteLine("Is a prime number");
            }

            else
            {
                Console.WriteLine("is not a prime number");
            }
        }
    }
}
