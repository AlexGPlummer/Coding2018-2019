using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgorithmPractice
{
    class Program
    {
        static char[] alpha = new char[26];
        static char[] decode = new char[26];
        static void Main(string[] args)
        {
            int answer = 90;
            while (answer != 0)
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("** Enter the number for thing you would like to do");
                Console.WriteLine("** 1. Run Problem 1");
                Console.WriteLine("** 2. Run Problem 2");
                Console.WriteLine("** 3. Run Problem 3");
                /*Console.WriteLine("** 4. Run Problem 4");
                Console.WriteLine("** 5. Run Problem 5");*/
                Console.WriteLine("** 0. Exit the program");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                answer = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                if (answer == 1)
                {
                    Problem1();
                }

                if (answer == 2)
                {
                    Problem2();
                }

                if (answer == 3)
                {
                    Problem3();
                }

                if (answer == 4)
                {
                   // Problem4();
                }

                if (answer == 5)
                {
                   // Problem5();
                }
            }
        }  

        static void Problem1()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Prob01.in_.txt";            
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            string line;
            float money = 0;
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains("QUARTER") == true)
                {
                    line = line.Substring(8);
                    money = (float.Parse(line) * .25f) + money;
                }
                if (line.Contains("DIME") == true)
                {
                    line = line.Substring(5);
                    money = (float.Parse(line) * .10f) + money;
                }
                if (line.Contains("NICKEL") == true)
                {
                    line = line.Substring(7);
                    money = (float.Parse(line) * .05f) + money;
                }
                if (line.Contains("PENNY") == true)
                {
                    line = line.Substring(6);
                    money = (float.Parse(line) * .01f) + money;
                }
                if (line.Contains("HALFDOLLAR") == true)
                {
                    line = line.Substring(11);
                    money = (float.Parse(line) * .50f) + money;
                }
            }
            Console.WriteLine("You have $" + money);
        }

        static void Problem2()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Prob02.in_.txt";
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] data = line.Split(null);                
                bool isvalid = true;
                foreach (string w in data)
                {
                    if (w == "-")
                    {
                        isvalid = false;
                        Console.WriteLine("The input was invalid");
                    }
                }
                foreach (char c in line)
                {
                    if (!Char.IsNumber(c) && c != '-' && c != ' ')
                    {
                        isvalid = false;
                        Console.WriteLine("The input was invalid");
                    }
                }
                if (isvalid == true)
                {
                    List<int> why = new List<int>();
                    for (int i = 0; i < data.Length; i++)
                    {
                        int x = Int32.Parse(data[i]);
                        why.Add(x);
                        //Console.WriteLine(x);
                    }
                    bool ascending = false;
                    bool desending = false;
                    for (int i = 0; i < data.Length - 1; i++)
                    {
                        if (why[i] > why[i + 1])
                        {
                            desending = true;
                        }
                        if (why[i] < why[i + 1])
                        {
                            ascending = true;
                        }
                    }
                    if (ascending == true && desending == true)
                    {
                        Console.WriteLine("The numbers are in a random order");
                    }
                    if (ascending == true && desending == false)
                    {
                        Console.WriteLine("The numbers are in a ascending order");
                    }
                    if (ascending == false && desending == true)
                    {
                        Console.WriteLine("The numbers are in a desending order");
                    }
                }
            }
        }

        static void Problem3()
        {
            lowercase();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Prob03.in_.txt";
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            string line;
            int count = 0;
            while ((line = file.ReadLine()) != null)
            {
                count++;
                if (count == 1)
                {
                    int o = 0;
                    foreach (char c in line)
                    {                        
                        decode[o] = c;
                        o++;
                    }
                }
                if (count > 1)
                {
                    string[] data = line.Split(null);
                    List<string> eh = new List<string>();
                    List<string> decoded = new List<string>();
                    foreach (string s in data)
                    {
                        string letter = "";
                        int letternumber;
                        foreach(char c in s)
                        {
                            if (c != '-')
                            {
                                letter = letter + c;
                            }
                            if (c == '-')
                            {
                                letternumber = Convert.ToInt32(letter);
                                Console.Write(decode[letternumber-1]);
                                letter = "";
                            }
                        }
                        letternumber = Convert.ToInt32(letter);
                        Console.Write(decode[letternumber-1] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }

        /*static void Problem4()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Prob04.in_.txt";
            System.IO.StreamReader file = new System.IO.StreamReader(path);
        }

        static void Problem5()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Prob05.in_.txt";
            System.IO.StreamReader file = new System.IO.StreamReader(path);
        }*/

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
    }
}
