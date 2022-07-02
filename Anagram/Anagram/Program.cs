using System;

namespace Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first word");
            string word1 = Console.ReadLine();

            Console.WriteLine("Enter second word");
            String word2 = Console.ReadLine();

            char[] array1 = word1.ToCharArray();
            char[] array2 = word2.ToCharArray();
            int count = 0;

            for(int i=0;i<array1.Length;i++)
            {
                for(int j=0;j<array2.Length;j++)
                {
                    if (array1[i] == array2[j])
                    {
                        count++;
                    }


                    
                }


                
            }

            if (count == array1.Length)
            {
                Console.WriteLine("The words are anagrams");
            }

        }
    }
}
