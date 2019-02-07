using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 90;
            while (answer != 0)
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("** Enter the number for thing you would like to do");
                Console.WriteLine("** 1. Run Problem 1");
                Console.WriteLine("** 2. Run Problem 2");
                Console.WriteLine("** 3. Run Problem 3");
                Console.WriteLine("** 0. Exit the program");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                answer = int.Parse(Console.ReadLine());

                if (answer == 1)
                {
                    List<string> types = new List<string> { "quarter", "dime", "nickel", "halfdollar", "penny" };
                    List<float> data = new List<float>(5);
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("How many " + types[i] + "s do you have?");
                        float o = float.Parse(Console.ReadLine());
                        data.Add(o);
                    }
                    problem1(data[0], data[1], data[2], data[3], data[4]);
                }

                if (answer == 2)
                {

                }

                if (answer == 3)
                {

                }
            }
        }
        static void problem1(float quarter, float dime, float nickel, float halfdollar, float penny)
        {
            float price = ((quarter * 0.25f) + (dime * 0.10f) + (nickel * 0.05f) + (halfdollar * 0.50f) + (penny * 0.01f));
            Console.WriteLine("The amount you have is $" + price);
        }
    }
}
