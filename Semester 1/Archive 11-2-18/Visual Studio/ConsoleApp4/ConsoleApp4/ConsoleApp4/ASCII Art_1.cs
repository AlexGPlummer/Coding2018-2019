//Alex Plummer
//ASCII Art
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;

            while (answer != 10)
            {
                Console.WriteLine("*************************************************************");
                Console.WriteLine("** Enter the integer value for the ASCII Art you want to print");
                Console.WriteLine("** 1. Print a 1x1 square");
                Console.WriteLine("** 2. Print a 3x3 square");
                Console.WriteLine("** 3. Print a 5x5 square");
                Console.WriteLine("** 4. Print a Triangle");
                Console.WriteLine("** 5. Print a Reverse Triangle");
                Console.WriteLine("** 6. Print a Pyramid");
                Console.WriteLine("** 7. Print Special #1");
                Console.WriteLine("** 8. Print Special #2");
                Console.WriteLine("** 9. Print Special #3");
                Console.WriteLine("** 10. Exit the program");
                Console.WriteLine("*************************************************************");
                answer = int.Parse(Console.ReadLine());
                Console.WriteLine("*************************************************************");
                if (answer == 1) //1x1 Square
                {
                    for (int i = 0; i < 1; i++)
                    {
                        for (int j = 0; j < 1; j++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                }
                if (answer == 2) //3x3 Square
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                }
                if (answer == 3) //5x5 Square
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                }
                if (answer == 4) //Triangle
                {
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < i; j++)
                        { 
                            Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                }
                if (answer == 5) //Inverse Triangle
                {
                    for (int j = 5; j > 0; j--)
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            if (i <= j - 1)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                }
                if (answer == 6) //Pyramid
                {
                    int n = 2;
                    for (int j = 3; j > 0; j--)
                    {
                        n++;
                        for (int i = 1; i <= n; i++)
                        {
                            if (i <= j - 1)
                                Console.Write(" ");
                            else if (i>=j)
                                Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                }
                if (answer == 7) //Special #1
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (i == j)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                }
                if (answer == 8) //Special #2
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (4 - i == j)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                }
                if (answer == 9) //Special #3
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (i == j || 4 - j == i)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                }                
            }
        }
    }
}
