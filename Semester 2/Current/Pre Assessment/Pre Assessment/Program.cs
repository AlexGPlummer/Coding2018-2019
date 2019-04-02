using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre_Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            while (answer != 87)
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Please enter the integer value of the action you want to preform");
                Console.WriteLine("1. Print Hello World");
                Console.WriteLine("2. Add two user input integers together");
                Console.WriteLine("3. Calculate the area of a circle given the radius from user input");
                Console.WriteLine("4. Calculate the area of a triangle given the length of all three sides from user input");
                Console.WriteLine("5. Given the integer n from user input, draw a square using the ASCII character 'X' that has the width of n");
                Console.WriteLine("6. Given the integer n from user input, draw a hollow square using ASII character 'X' that has the width of n");
                Console.WriteLine("7. Given two integer variables from user input, swap their values");
                Console.WriteLine("8. Reverse a string from user input using a for loop");
                Console.WriteLine("9. End the program");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    Console.Clear();
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("Hello World!");
                }
                if (answer == 2)
                {
                    Console.Write("Please enter the first integer you want to add: ");
                    int integer1 = int.Parse(Console.ReadLine());
                    Console.Write("Please enter the second intger you want to add: ");
                    int integer2 = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine(integer1 + " + " + integer2 + " = " + (integer1 + integer2));
                }
                if (answer == 3)
                {
                    Console.Write("Please enter radius of circle to calculate area: ");
                    float r = float.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("The area of circle with radius " + r + " is " + (Math.PI * (r * r)));
                }
                if (answer == 4)
                {
                    Console.Write("Input length of side A of triangle: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Input length of side B of triangle: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.Write("Input length of side C of triangle: ");
                    int c = int.Parse(Console.ReadLine());
                    int p = (a + b + c) / 2;
                    Console.Clear();
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("The area of triangle with sides of " + a + ", " + b + ", and " + c + " is " + Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
                }
                if (answer == 5)
                {
                    Console.Write("What size square do you want to draw: ");
                    int n = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write('X');
                        }
                        Console.WriteLine();
                    }
                }
                if (answer == 6)
                {
                    Console.Write("What size square do you want to draw: ");
                    int n = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (j == 0 || j == (n - 1) || i == 0 || i == (n - 1))
                            {
                                Console.Write('X');
                            }
                            else
                            {
                                Console.Write(' ');
                            }
                        }
                        Console.WriteLine();
                    }
                }
                if (answer == 7)
                {
                    Console.Write("Please enter the first integer value you want to swap: ");
                    int integer1 = int.Parse(Console.ReadLine());
                    Console.Write("Please enter the second integer value you want to swap: ");
                    int integer2 = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("Swapping " + integer1 + " and " + integer2 + ".");
                    Console.WriteLine("After swap values are " + integer2 + " and " + integer1 + ".");
                }
                if (answer == 8)
                {
                    Console.Write("Please enter the string you want to reverse: ");
                    string startingword = Console.ReadLine();
                    char[] array = startingword.ToCharArray();
                    Console.Clear();
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("Original string = " + startingword);
                    Console.Write("Reversed string = ");
                    for (int i = array.Length; i > 0; i--)
                    {
                        Console.Write(array[i-1]);
                    }
                    Console.WriteLine();
                }
                if (answer == 9)
                {
                    Console.Clear();
                    yeet();
                    Console.WriteLine("Thank you for using this program.");
                    Console.Write("Press any key to end program . . . ");
                    Console.ReadLine();
                    answer = 87;
                }
            }
        }
        static void yeet()
        {
            Console.WriteLine("          ______");
            Console.WriteLine("    .---< __. \\ \\");
            Console.WriteLine("     `---._  \\ \\ \\");
            Console.WriteLine("      ,----`- `.)) ");
            Console.WriteLine("     / ,--.   )  |");
            Console.WriteLine("    /_/    >     |");
            Console.WriteLine("    |,\\__-'      |");
            Console.WriteLine("     \\_           \\");
            Console.WriteLine("       ~~-___      )");
            Console.WriteLine("             \\      \\");
        }
    }
}
