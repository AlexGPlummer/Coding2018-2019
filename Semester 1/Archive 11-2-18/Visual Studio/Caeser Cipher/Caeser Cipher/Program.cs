using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caeser_Cipher
{
    class Program
    {
        static int shift = 0;
        static string input = "no";
        static char[] shifted = new char['a'];
        static void Main(string[] args)
        {
            int answer = 0;
            while (answer != 3)
            {
                Console.WriteLine("*************************************************************");
                Console.WriteLine("** Enter the integer value for the action you want to perform");
                Console.WriteLine("** 1. Cipher word");
                Console.WriteLine("** 2. Decipher word");                
                Console.WriteLine("** 3. Exit the program");
                Console.WriteLine("*************************************************************");
                answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    Console.WriteLine("Enter a word you want to be shifted");
                    string imput = Console.ReadLine();                    
                    Console.WriteLine("Enter the number you want the letters to be shifted by");
                    shift = int.Parse(Console.ReadLine());
                    Encrypt(imput, shift);

                }
                if (answer == 2)
                {
                    Console.WriteLine("Enter a word you want to be deciphered");
                    string input = Console.ReadLine();
                    char[] shifted = new char[input.Length];
                    char[] array = input.ToCharArray();
                    Console.WriteLine("Enter the number you want the cipher to be deciphered by");
                    int shift = int.Parse(Console.ReadLine());
                    for (int i = 0; i < input.Length; i++)
                    {
                        char letter = array[i];
                        int myint = letter;
                        for (int j = 0; j < shift; j++)
                        {
                            myint = myint - 1;
                            if (myint <= 64)
                            {
                                myint = 90;
                            }
                            if (myint <= 96 && myint > 90)
                            {
                                myint = 122;
                            }
                        }                        
                        letter = (char)myint;
                        shifted[i] = letter;
                    }
                    string output = new string(shifted);
                    Console.WriteLine("Here is your word shifted backwards by " + shift);
                    Console.WriteLine(output);
                }
            }            
        }
        static void Encrypt(string input, int shift)
        {
            
            for (int i = 0; i < input.Length; i++)
            {
                char[] shifted = new char[input.Length];
                char[] array = input.ToCharArray();
                char letter = array[i];
                int myint = letter;
                for (int j = 0; j < shift; j++)
                {
                    myint = myint + 1;
                    if (myint >= 90 && myint < 97)
                    {
                        myint = 65;
                    }
                    if (myint >= 122)
                    {
                        myint = 97;
                    }
                }
                letter = (char)myint;
                shifted[i] = letter;
            }
            string output = new string(shifted);
            Console.WriteLine("Here is your word shifted by " + shift);
            Console.WriteLine(output);
        }
    }
}
