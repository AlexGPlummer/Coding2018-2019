using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            while (answer != 2)
            {
                Console.WriteLine("*************************************************************");
                Console.WriteLine("** Enter the integer value for the action you want to perform");
                Console.WriteLine("** 1. Palindrome Checker");                
                Console.WriteLine("** 2. Exit the program");
                Console.WriteLine("*************************************************************");
                answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    Console.WriteLine("Enter a palindrome");
                    string word = Console.ReadLine();
                    char[] reverse = word.ToCharArray();
                    Array.Reverse(reverse);
                    Console.WriteLine("*************************************************************");
                    Console.WriteLine("Reverse");
                    Console.WriteLine(new string(reverse));
                    if (new string(reverse) == word)
                    {
                        Console.WriteLine("That is a palindrome");
                    }
                    else
                    {
                        Console.WriteLine("That is not a palindrome");
                    }
                }
            } 
        }
    }
}
