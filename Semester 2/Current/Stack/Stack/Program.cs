using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            Stack myStack = new Stack();
            while (answer != 4)
            {
                Console.WriteLine("*************************************************************");
                Console.WriteLine("** Enter the integer value for the action you want to perform");
                Console.WriteLine("** 1. ");
                Console.WriteLine("** 2. ");
                Console.WriteLine("** 3. ");
                Console.WriteLine("** 4. Exit the program");
                Console.WriteLine("*************************************************************");
                answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {

                }

                if (answer == 2)
                {

                }

                if (answer == 3)
                {

                }
            }
        }
    }
}
