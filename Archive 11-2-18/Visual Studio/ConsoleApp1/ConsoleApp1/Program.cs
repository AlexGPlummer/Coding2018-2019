using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static char[] alpha = new char[26];
        static void Main(string[] args)
        {
            int answer = 0;
            while (answer != 4)
            {
                Console.WriteLine("*************************************************************");
                Console.WriteLine("** Enter the integer value for the action you want to perform");
                Console.WriteLine("** 1. Lowercase character values");
                Console.WriteLine("** 2. Uppercase character values");
                Console.WriteLine("** 3. 0-13000 values");
                Console.WriteLine("** 4. Exit the program");
                Console.WriteLine("*************************************************************");
                answer = int.Parse(Console.ReadLine());
                Console.WriteLine("*************************************************************");
                if (answer == 1)
                {
                    lowercase();
                    alphabet();
                }
                if (answer == 2)
                {
                    uppercase();
                    alphabet();
                }
                if (answer == 3)
                {
                    for (int i = 0; i < 13000; i++)
                    {
                        int myint = i;
                        char mychar = (char)myint;
                        Console.Write(mychar);
                    }
                    Console.WriteLine();
                }
            }
        }
        static void lowercase()
        {
            alpha[0] = 'a';
            alpha[1] = 'b';
            alpha[2] = 'c';
            alpha[3] = 'd';
            alpha[4] = 'e';
            alpha[5] = 'f';
            alpha[6] = 'g';
            alpha[7] = 'h';
            alpha[8] = 'i';
            alpha[9] = 'j';
            alpha[10] = 'k';
            alpha[11] = 'l';
            alpha[12] = 'm';
            alpha[13] = 'n';
            alpha[14] = 'o';
            alpha[15] = 'p';
            alpha[16] = 'q';
            alpha[17] = 'r';
            alpha[18] = 's';
            alpha[19] = 't';
            alpha[20] = 'u';
            alpha[21] = 'v';
            alpha[22] = 'w';
            alpha[23] = 'x';
            alpha[24] = 'y';
            alpha[25] = 'z';
        }
        static void uppercase()
        {
            alpha[0] = 'A';
            alpha[1] = 'B';
            alpha[2] = 'C';
            alpha[3] = 'D';
            alpha[4] = 'E';
            alpha[5] = 'F';
            alpha[6] = 'G';
            alpha[7] = 'H';
            alpha[8] = 'I';
            alpha[9] = 'J';
            alpha[10] = 'K';
            alpha[11] = 'L';
            alpha[12] = 'M';
            alpha[13] = 'N';
            alpha[14] = 'O';
            alpha[15] = 'P';
            alpha[16] = 'Q';
            alpha[17] = 'R';
            alpha[18] = 'S';
            alpha[19] = 'T';
            alpha[20] = 'U';
            alpha[21] = 'V';
            alpha[22] = 'W';
            alpha[23] = 'X';
            alpha[24] = 'Y';
            alpha[25] = 'Z';
        }
        static void alphabet()
        {
            for (int i = 0; i < alpha.Length; i++)
            {
                char mychar = alpha[i];
                int myint = mychar;
                Console.WriteLine(mychar + " = " + myint);
            }
        }
    }
}
