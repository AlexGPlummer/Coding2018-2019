using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //This code will create a menu to ask the user if they want to play or exit programm
            int answer = 0;
            

            while (answer != 2)
            {
                
                Console.WriteLine("*************************************************************");
                Console.WriteLine("** Enter the integer value for the action you want to perform");
                Console.WriteLine("** 1. Play Guess The Number");
                Console.WriteLine("** 2. Exit The Program");          
                Console.WriteLine("*************************************************************");
                //This code will create the variables and rand (Random)
                Random rand = new Random();
                int number = 0;
                

                answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    int g = 0;
                    int s = rand.Next(1000);
                    //Write a Loop while the number is != s
                    while (number != s)
                    {
                        g = g + 1;
                        //Write Guess the number I am thinking of 0-1000
                        Console.WriteLine("Guess the number I am thinking of 1-1000");
                        //Read their guess
                        number = int.Parse(Console.ReadLine());
                        
                        if (number > s)
                        {
                            Console.WriteLine("Too high, try again.");
                            Console.WriteLine("*************************************************************");
                        }
                        else if (number < s)
                        {
                            Console.WriteLine("Too low, try again.");
                            Console.WriteLine("*************************************************************");
                        }
                    }
                    Console.WriteLine("Good job, you guessed the number! It took you " + g + " guesses.");
                }  
            }
        }
    }
}
