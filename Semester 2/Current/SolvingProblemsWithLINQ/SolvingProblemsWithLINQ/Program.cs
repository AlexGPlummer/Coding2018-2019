using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingProblemsWithLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> data = new List<char>() { '0', '-', '4', '-', '5', '-', '7', '9', '-', '6' };
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            original(data);
            LinqMethod(data);
        }

        static void original(List<char> data)
        {            
            List<char> numbers = new List<char>();
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i] != '-')
                {
                    numbers.Add(data[i]);
                }
            }
            Console.WriteLine("Original Method");
            Print(numbers);
        }

        static void LinqMethod(List<char> data)
        {
            List<char> numbers = data.Where(t => t !='-').ToList();
            Console.WriteLine("LINQ Method");
            Print(numbers);
        }
        
        static void Print(List<char> numbers)
        {
            Console.Write("| ");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " | ");
            }
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}
