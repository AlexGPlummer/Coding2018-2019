using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int input = 0;
        Random rand = new Random();
        int[] coaster = new int[10];

        do
        {
            Console.WriteLine("***************************************************");
            Console.WriteLine("** 1. Add a person to a random slot in the coaster");
            Console.WriteLine("** 2. List the available seats in the ride.");
            Console.WriteLine("** 3. Start the ride and print # of people on the ride");
            Console.WriteLine("** 4. Exit the program.");
            Console.WriteLine("***************************************************");

            input = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            //Add person to random slot in the coaster
            if (input == 1)
            {
                bool isSeatAvail = false;
                for (int i = 0; i < coaster.Length; i++)
                {
                    if (coaster[i] == 0)
                    {
                        isSeatAvail = true;
                    }
                }

                if (isSeatAvail == true)
                {
                    do
                    {
                        int selection = rand.Next(0, 10);
                        if (coaster[selection] == 0)
                        {
                            coaster[selection] = 1;
                            Console.WriteLine("Adding person to ride index: " + selection);
                            break;
                        }
                    } while (true);
                }
                else
                {
                    Console.WriteLine("No seat is available, unable to add another person to the ride.");
                }
            }
            //list the available seats in the ride
            else if (input == 2)
            {
                Console.WriteLine("Front                                Back");
                Console.WriteLine("-----------------------------------------");
                Console.Write("|");
                for (int i = 0; i < coaster.Length; i++)
                {
                    Console.Write(" " + coaster[i] + " |");
                }
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------");
            }
            //start the ride and print the # of people on the ride
            else if (input == 3)
            {
                int count = 0;
                for (int i = 0; i < coaster.Length; i++)
                {
                    if (coaster[i] == 1)
                    {
                        count++;
                        coaster[i] = 0;
                    }
                }

                Console.WriteLine(count + " people were on this ride.");
            }
            else if (input == 4)
            {
                Console.WriteLine("Exiting application.");
            }
            else
            {
                Console.WriteLine("You have entered an invalid option, please try again.");
            }

            Console.WriteLine();
            Console.WriteLine();
        } while (input != 4);
    }
}