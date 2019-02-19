using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuestWithCyber
{
    class Program
    {
        static void Main(string[] args)
        {
            problem1();
            problem2();
            string j = Console.ReadLine();
        }

        static void problem1()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Prob01.in.txt";
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] data = line.Split(',');
                List<int> data2 = new List<int>();
                for (int i = 0; i < data.Length; i++)
                {
                    int x = Int32.Parse(data[i]);
                    data2.Add(x);
                    //Console.WriteLine(x);
                }
                for (int i = 0; i < data.Length; i++)
                {
                    for (int j = 0; j < data.Length; j++)
                    {
                        if (data2[i] < data2[j])
                        {
                            int temp = data2[i];
                            data2[i] = data2[j];
                            data2[j] = temp;
                        }
                    }
                }
                Console.Write("| ");
                for (int i = 0; i < data2.Count; i++)
                {
                    Console.Write(data2[i] + " | ");
                }
                Console.WriteLine();
            }
        }

        static void problem2()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Prob02.in.txt";
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                char[] data = line.ToCharArray();
                for (int i = data.Length - 1; i >= 0; i--)
                {
                    Console.Write(data[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
