using System;

namespace SimpleBalancedParenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String number = "(a+b)";
            char[] array = number.ToCharArray();

            LinkedList list = new LinkedList();

            for(int i=0;i<array.Length;i++)
            {
                if (array[i]=='(')
                {
                    list.Push(10);
                }
            }
        }
    }
}
