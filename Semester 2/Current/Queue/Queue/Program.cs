using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericQueue
{
    class Program
    {

        static void Main(string[] args)
        {
            genericQueue();
        }
        static void genericQueue()
        {
            QueueGeneric<int> T = new QueueGeneric<int>();            
            int answer = 0;
            while (answer != 5)
            {
                Console.WriteLine("*************************************************************");
                Console.WriteLine("** Enter the integer value for the action you want to perform");
                Console.WriteLine("** 1. Add a number to the back of the Queue");
                Console.WriteLine("** 2. Remove the front element of the Queue");
                Console.WriteLine("** 3. See what's the first element in the Queue");
                Console.WriteLine("** 4. Print the Queue");
                Console.WriteLine("** 5. Exit the program");
                Console.WriteLine("*************************************************************");
                answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    //EnQueue
                    Console.Clear();
                    Console.WriteLine("What number would you like to add to the Queue");
                    int y = int.Parse(Console.ReadLine());
                    Console.WriteLine("*************************************************************");
                    T.EnQueue(y);
                }
                if (answer == 2)
                {
                    Console.Clear();
                    //DeQueue
                    Console.WriteLine("*************************************************************");
                    T.DeQueue();
                }
                if (answer == 3)
                {
                    Console.Clear();
                    //Peek
                    Console.WriteLine("*************************************************************");
                    T.Peek();
                }
                if (answer == 4)
                {
                    Console.Clear();
                    //Print
                    Console.WriteLine("*************************************************************");
                    //T.Print();
                }
            }
        }

    }
}
namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Queue();
        }

        static void Queue()
        {
            Queue myQueue = new Queue();
            int answer = 0;
            while (answer != 5)
            {
                Console.WriteLine("*************************************************************");
                Console.WriteLine("** Enter the integer value for the action you want to perform");
                Console.WriteLine("** 1. Add a number to the back of the Queue");
                Console.WriteLine("** 2. Remove the front element of the Queue");
                Console.WriteLine("** 3. See what's the first element in the Queue");
                Console.WriteLine("** 4. Print the Queue");
                Console.WriteLine("** 5. Exit the program");
                Console.WriteLine("*************************************************************");
                answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    //EnQueue
                    Console.Clear();
                    Console.WriteLine("What number would you like to add to the Queue");
                    int y = int.Parse(Console.ReadLine());
                    Console.WriteLine("*************************************************************");
                    myQueue.EnQueue(y);
                }
                if (answer == 2)
                {
                    Console.Clear();
                    //DeQueue
                    Console.WriteLine("*************************************************************");
                    myQueue.DeQueue();
                }
                if (answer == 3)
                {
                    Console.Clear();
                    //Peek
                    Console.WriteLine("*************************************************************");
                    myQueue.Peek();
                }
                if (answer == 4)
                {
                    Console.Clear();
                    //Print
                    Console.WriteLine("*************************************************************");
                    myQueue.Print();
                }
            }
        }
    }
}
