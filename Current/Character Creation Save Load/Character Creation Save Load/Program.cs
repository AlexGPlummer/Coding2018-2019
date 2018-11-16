using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Character_Creation_Save_Load
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int answer = 0;
            Random rand = new Random();

            while (answer != 6)
            {
                Console.WriteLine("*************************************************************");
                Console.WriteLine("** Enter the integer value for the action you want to perform");
                Console.WriteLine("** 1. Create a character");
                Console.WriteLine("** 2. Modify a character");
                Console.WriteLine("** 3. Delete a character");
                Console.WriteLine("** 4. Load existing characters");
                Console.WriteLine("** 5. List characters");
                Console.WriteLine("** 6. Exit the program");
                Console.WriteLine("*************************************************************");
                answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    Console.Write("What is your name: ");
                    string name = Console.ReadLine();
                    int st = rand.Next(10);
                    Console.Write(st);
                    Character susan = new Character(name, 9, 100, rand.Next(10), rand.Next(10), 50);
                }
                if (answer == 2)
                {

                }

                if (answer == 3)
                {

                }

                if (answer == 4)
                {

                }
                
                if (answer == 5)
                {

                }
            }
        }
        
    }    
}
