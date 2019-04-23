using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Insert('y');
            tree.Insert('e');
            tree.Insert('p');
            tree.Insert('q');
            tree.Insert('u');
            tree.Insert('b');
            tree.Insert('m');
            tree.Insert('z');
            tree.Insert('x');

            int answer = 90;
            while (answer != 0)
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("** Enter the number for thing you would like to do");
                Console.WriteLine("** 1. Insert an integer/letter");
                Console.WriteLine("** 2. Search for an integer/letter");
                Console.WriteLine("** 3. Remove an integer/letter");
                Console.WriteLine("** 4. PreOrderPrint the Binary Tree");
                Console.WriteLine("** 5. InOrderPrint the Binary Tree");
                Console.WriteLine("** 6. PostOrderPrint the Binary Tree");
                Console.WriteLine("** 0. Exit the program");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                answer = int.Parse(Console.ReadLine());

                if (answer == 1)
                {

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

                if (answer == 0)
                {
                    Console.WriteLine("Thank you for using this program!");
                    Console.WriteLine("Press enter to end . . .");
                    Console.ReadKey();
                }
            }
        }
    }
}
