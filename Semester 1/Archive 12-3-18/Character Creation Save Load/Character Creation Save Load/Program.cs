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
            Character current = new Character(" ", 0, 0, 0, 0, 0, 0);
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
                //Console.WriteLine("** 5. Play Game");
                Console.WriteLine("** 6. Exit the program");
                Console.WriteLine("*************************************************************");
                answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    //Creates characters
                    Console.Write("What is the name of the character?: ");
                    string name = Console.ReadLine();
                    current = new Character(name, 9, 100, 1, 1, 50, 30);
                    //Calls to save character
                    SaveCharacter(current);
                }
                if (answer == 2)
                {
                    //Modifys character
                    ModifyCharacter(current);
                    SaveCharacter(current);
                }

                if (answer == 3)
                {
                    //Deletes character requested
                    Console.WriteLine("What is the name of the character you wish to delete?");
                    string charactername = Console.ReadLine();
                    DeleteCharacter(charactername);
                }

                if (answer == 4)
                {
                    //Loads character
                    Console.WriteLine("What is the name of the character you wish to load?");
                    string charactername = Console.ReadLine();
                    current = LoadCharacter(charactername);
                }
            }
        }
        //Saves Character
        static void SaveCharacter(Character character)
        {
            //Creates Path
            string path = AppDomain.CurrentDomain.BaseDirectory + "Characters\\" + character.name + ".txt";
            //Checks if the files exists
            if (File.Exists(path))
            {
                Console.Write("File exists, would you like to overwrite it? y or n: ");
                Char YorN = char.Parse(Console.ReadLine());
                if (YorN == 'y')
                {
                    //Overwrites the last character file with the new info
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
                    Console.WriteLine("File Overwritten");
                }
                if (YorN == 'n')
                {
                    Console.WriteLine("Nothing Overwritten");
                }
            }
            else
            //Creates new character file
            {
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
                Console.WriteLine("Character Created");
            }
        }
        //Modifies the current character
        static void ModifyCharacter(Character character)
        {
            int ans = 0;
            while (ans != 4)
            {
                Console.WriteLine("*************************************************************");
                Console.WriteLine("You have " + character.points + " points to spend on health, strength, or speed.");
                Console.WriteLine("You currently have " + character.health + " health, " + character.strength + " strength, and " + character.speed + " speed.");
                Console.Write("If you want to edit health enter 1, if you want to edit strength enter 2, if you want to edit speed press 3, if you want to exit enter 4: ");
                Console.WriteLine("*************************************************************");
                ans = int.Parse(Console.ReadLine());
                if (ans == 1)
                {
                    if (character.points > 0)
                    {
                        Console.Write("How many points do you want to increase your health by? ");
                        int healthChange = int.Parse(Console.ReadLine());
                        if (healthChange <= character.points)
                        {
                            character.health = character.health + healthChange;
                            character.points = character.points - healthChange;
                        }
                        if (healthChange > character.points)
                        {
                            Console.WriteLine("You enter a larger number than points available, health change did not go through.");
                        }
                    }
                }

                if (ans == 2)
                {
                    if (character.points > 0)
                    {
                        Console.Write("How many points do you want to increase your strength by? ");
                        int strengthChange = int.Parse(Console.ReadLine());
                        if (strengthChange <= character.points)
                        {
                            character.strength = character.strength + strengthChange;
                            character.points = character.points - strengthChange;
                        }
                        if (strengthChange > character.points)
                        {
                            Console.WriteLine("You entered a larger number than points available, strength change did not go through.");
                        }
                    }
                }

                if (ans == 3)
                {
                    if (character.points > 0)
                    {
                        Console.Write("How many points do you want to increase your speed by? ");
                        int speedChange = int.Parse(Console.ReadLine());
                        if (speedChange <= character.points)
                        {
                            character.speed = character.speed + speedChange;
                            character.points = character.points - speedChange;
                        }
                        if (speedChange > character.points)
                        {
                            Console.WriteLine("You entered a larger number than the points available, speed change did not go through.");
                        }
                    }
                }
            }
        }
        static bool DeleteCharacter(string characterName)
        {
            bool delete = false;
            string path = AppDomain.CurrentDomain.BaseDirectory + "Characters\\" + characterName + ".txt";
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("Character Deleted");
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
            return delete;
        }
        static Character LoadCharacter(string characterName)
        {
            string n = " ";
            int l = 0;
            int h = 0;
            int st = 0;
            int sp = 0;
            int hung = 0;
            int p = 0;
            string path = AppDomain.CurrentDomain.BaseDirectory + "Characters\\" + characterName + ".txt";
            if (File.Exists(path))
            {
                using (StreamReader w = new StreamReader(path))
                {

                    n = w.ReadLine();

                    h = int.Parse(w.ReadLine());

                    st = int.Parse(w.ReadLine());

                    sp = int.Parse(w.ReadLine());

                    hung = int.Parse(w.ReadLine());

                    p = int.Parse(w.ReadLine());

                }
            }
            else
            {
                Console.WriteLine("Character does not exist");
            }
            Character current = new Character(n, l, h, st, sp, hung, p);
            return current;
        }
    }
}
