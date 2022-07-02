using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBalancedParenthesis
{
    internal class LinkedList
    {
        public static Node head;
        public void Add(String data)
        {
            Node node = new Node(data);
            if (node == null)
            {
                head = node;
            }
            else
            {
                node.next = head;
                head = node;
                Console.WriteLine(head.data);
            }

        }

        public void pop(String data)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                
            }
            else
            {
                Node temp = head;
                Node p = head;
                // Console.WriteLine(temp.next);
                while (temp.next != null)
                {
                    if (temp.data.CompareTo(data) == ')')
                    {
                        p = temp.next;
                        Console.WriteLine(temp.data);
                        

                    }
                    temp = temp.next;
                }

            }
            
        }
    }
    }
}
