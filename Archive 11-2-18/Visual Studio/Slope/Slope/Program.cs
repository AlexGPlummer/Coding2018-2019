using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slope
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;

            while (answer != 4)
            {
                menu();
                answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    print(3,3);
                }

                if (answer == 2)
                {
                    print(3,6);
                }

                if (answer == 3)
                {
                    print(6,3);
                }
            }
        }
        static void print(int size, int by)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < by; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }
        static void menu()
        {            
            Console.WriteLine("*************************************************************");
            Console.WriteLine("** Enter the integer value for the action you want to perform");
            Console.WriteLine("** 1. Print a 3x3 square");
            Console.WriteLine("** 2. Print a 3X6 reactangle");
            Console.WriteLine("** 3. Print a 6X3 reactangle");
            Console.WriteLine("** 4. Exit the program");
            Console.WriteLine("*************************************************************");
        }
    }
}
