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

        static string name = " ";
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
                    Console.Write("What is the name of the character?: ");
                    name = Console.ReadLine();                    
                    Character susan = new Character(name, 9, 100, 1, 1, 50, 30);
                    SaveCharacter(susan);
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
        static void SaveCharacter(Character character)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory +  "Characters\\" + character.name + ".txt";
            using (StreamWriter w = new StreamWriter(path))
            {
                w.WriteLine(character.name);
                w.WriteLine(character.lives);
                w.WriteLine(character.health);
                w.WriteLine(character.strength);
                w.WriteLine(character.speed);
                w.WriteLine(character.hunger);
                w.WriteLine(character.points);
            }
        }
        static void ModifyCharacter(Character character)
        {
            int ans = 0;
            while (ans != 4)
            {
                //Console.Clear();
                Console.WriteLine("You have " + character.points + " points to spend on health, strength, or speed.");
                Console.WriteLine("You currently have " + character.health + " health, " + character.strength + " strength, and " + character.speed + " speed.");
                Console.Write("If you want to edit health enter 1, if you want to edit strength enter 2, if you want to edit speed press 3, if you want to exit enter 4: ");
                ans = int.Parse(Console.ReadLine());
                if (ans == 1)
                {
                    if (character.points > 0)
                    {
                        Console.Write("How many points do you want to increase your health by? ");
                        int healthChange = int.Parse(Console.ReadLine());
                        if (healthChange <= character.points)
                        {

                        }
                        if (healthChange > character.points)
                        {
                            Console.WriteLine("You enter a larger number than points, health change did no go through.");
                        }
                    }
                }

                if (ans == 2)
                {
                    if (character.points > 0)
                    {
                        Console.Write("How many points do you want to increase your strength by? ");
                    }
                }

                if (ans == 3)
                {
                    if (character.points > 0)
                    {
                        Console.Write("How many points do you want to increase your speed by? ");
                    }
                }
            }            
        }
    }    
}
