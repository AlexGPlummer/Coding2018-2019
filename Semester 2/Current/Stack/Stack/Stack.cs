using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack
    {
        int myInt;
        List<int> Q = new List<int>();
        public int DeQueue()
        {
            if (Q.Count < 1)
            {
                Console.WriteLine("There are no integers in the list");
            }
            else
            {
                myInt = Q[0];
                Q.Remove(Q[0]);
                Console.WriteLine("The first element has been removed.");
            }
            return myInt;
        }
        public void EnQueue(int val)
        {
            Q.Add(val);
            Console.WriteLine("The interger " + val + " has been added to the Queue");
        }
        public int Peek()
        {
            if (Q.Count > 0)
            {
                myInt = Q[0];
                Console.WriteLine("The first element is " + myInt);
            }
            else
            {
                Console.WriteLine("There are no integers in the list");
            }
            return myInt;
        }
        public void Print()
        {
            if (Q.Count > 0)
            {
                Console.Write("| ");
                foreach (int i in Q)
                {
                    Console.Write(i + " | ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("There are no intergers in the Queue");
            }
        }
    }
}
