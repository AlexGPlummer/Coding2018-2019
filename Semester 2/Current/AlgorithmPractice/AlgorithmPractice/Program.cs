using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
                    string path = AppDomain.CurrentDomain.BaseDirectory + "Prob01.in_.txt";
                    string line;                   
                    System.IO.StreamReader file = new System.IO.StreamReader(path);
                    List<string> types = new List<string> {"QUARTER", "DIME", "NICKEL", "HALFDOLLAR", "PENNY"};
                    List<float> data = new List<float>(5);                    
                    for (int i = 0; i < 5; i++)
                    {
                        float o = 0;
                        while ((line = file.ReadLine()) != null)
                        {
                            //if line contains types[i] then add the number to data
                            if (line.Contains(types[i]) == true )
                            {
                                line = line.Substring(types[i].Length + 1);
                                o = float.Parse(line) + o;
                                data.Add(o);
                            }
                            //System.Console.WriteLine(line);
                        }
                        if (data.Count < i)
                        {
                            data.Add(0);
                        }
                    }
                    for (int i = 0; i < data.Count; i++)
                    {
                        Console.WriteLine(data[i]);
                    }
                    //problem1(data[0], data[1], data[2], data[3], data[4]);
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
