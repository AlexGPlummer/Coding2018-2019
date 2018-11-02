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
            //Create a program that has a menu with the following options:
            //1.Put rider in random available seat. (Ride seats 10 riders)
            //2.List available seats.
            //3.Start ride, print out how many people were on the ride.
            //4.Exit program.
            int[] coaster = new int(10);
            Random rand = new Random();
            int Input = 0;

            //Continue to loop until 4
            do
            {
                Console.WriteLine("*************************************************************");
                Console.WriteLine("** 1. Add a rider to a random seat");
                Console.WriteLine("** 2. List avaliable seats");
                Console.WriteLine("** 3. Start ride, list how many riders");
                Console.WriteLine("** 4. Exit the program");
                Console.WriteLine("*************************************************************");
                Input = int.Parse(Console.ReadLine());
                if (Input == 1)
                {
                    int count = 0;
                    for (int i = 0; 1 < coaster.Length; i++)
                    do
                    {
                        int selectedchair = rand.Next(0, 10);
                        if (coaster[selectedchair] == 0)
                        {
                            coaster[selectedchair] = 1;
                                Console.WriteLine("Person added to seat #" + selectedchair);
                        }
                    } while (true);
                }

                if (Input == 2)
                {

                }

                if (Input == 3)
                {

                }
            } while (true);
        }
    }
}
