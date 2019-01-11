using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static int x = 5;
        static void Main(string[] args)
        {
            int answer = 0;

            while (answer != 4)
            {
                Console.WriteLine("*************************************************************");
                Console.WriteLine("** Enter the integer value for the action you want to perform");
                Console.WriteLine("** 1. Adds 5 + 6");
                Console.WriteLine("** 2. Adds 11 + 13");
                Console.WriteLine("** 3. Adds 3 + 9");
                Console.WriteLine("** 4. Exit the program");
                Console.WriteLine("*************************************************************");
                answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    One();
                }

                if (answer == 2)
                {
                    Two();
                }

                if (answer == 3)
                {
                    Three();
                }
            }
        }
        static void One()
        {
            int i = 5 + 6;
            Console.WriteLine(i);
        }
        static void Three()
        {
            int i = 3 + 9;
            Console.WriteLine(i);
        }
        static void Two()
        {
            int i = 11 + 13;
            Console.WriteLine(i);
        }
    }
}
