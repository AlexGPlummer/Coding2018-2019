using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CodeQuesto
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProblemUno();
            //ProblemDos();
            //ProblemTres();
            //ProblemCuatro();
            //ProblemCinco();
            ProblemSeis();
            Console.WriteLine("Press enter to exit the program . . .");
            Console.ReadLine();
        }
        static void ProblemUno()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Prob01.in.txt";
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
        static void ProblemDos()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Prob02.in.txt";
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(String.Join("",line.Reverse()));
            }
        }
        static void ProblemTres()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Prob03.in.txt";
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            string line;
            int txt=0;
            int doc=0;
            int outCount=0;
            int so=0;
            int dll=0;
            while ((line = file.ReadLine()) != null)
            {
                if(line.Contains(".txt"))
                {
                    txt+= 1;
                }
                if (line.Contains(".doc"))
                {
                    doc += 1;
                }
                if (line.Contains(".out"))
                {
                    outCount += 1;
                }
                if (line.Contains(".so"))
                {
                    so += 1;
                }
                if (line.Contains(".dll"))
                {
                    dll += 1;
                }
            }
            Console.WriteLine("txt " + txt);
            Console.WriteLine("doc " + doc);
            Console.WriteLine("out " + outCount);
            Console.WriteLine("so " + so);
            Console.WriteLine("dll " + dll);
        }
        static void ProblemCuatro()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Prob04.in.txt";
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                List<int> numb = new List<int>();
                string[] s = line.Split(',');
                foreach(string st in s)
                {
                    numb.Add(int.Parse(st));
                }
                numb.Sort();
                foreach(int i in numb)
                {
                    Console.Write(i + ",");
                }
                Console.WriteLine();
            }
        }
        static void ProblemCinco()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Prob05.in.txt";
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            string line;
            int run = 0;
            string[] date;
            double datetotal = 0;
            while ((line = file.ReadLine()) != null)
            {
                if (run == 0)
                {
                    date = line.Split('/');                    
                    datetotal = int.Parse(date[1]) + (int.Parse(date[0]) * 30) + (int.Parse(date[2]) * 365);
                }
                else
                {
                    string[] c = line.Split(':');
                    string[] checkdate = c[1].Split('/');
                    double checkdatetotal = int.Parse(checkdate[1]) + (int.Parse(checkdate[0]) * 30) + (int.Parse(checkdate[2]) * 365);
                    double days = datetotal - checkdatetotal;
                    if(days>180)
                    {
                        Console.WriteLine(c[0] + ", " + days);
                    }
                }

                run++;
            }
        }
        static void ProblemSeis()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Prob06.in.txt";
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            string line;
            List<int> scores = new List<int>();
            List<string> names = new List<string>();
            while ((line = file.ReadLine()) != null)
            {
                int score = 0;
                string[] c = line.Split(':');
                string[] currentscore = c[1].Split(',');
                foreach (string yeet in currentscore)
                {
                    score = score + int.Parse(yeet);
                }
                scores.Add(score);
                names.Add(c[0]);
            }
            for (int i = 0; i < scores.Count; i++)
            {
                for (int j = 0; j < scores.Count; j++)
                {
                    if (scores[i] < scores[j])
                    {
                        int yeet = scores[i];
                        scores[i] = scores[j];
                        scores[j] = yeet;
                        string otheryeet = names[i];
                        names[i] = names[j];
                        names[j] = otheryeet;
                    }
                }
            }
            Console.WriteLine("First: " + names[0]);
            Console.WriteLine("Second: " + names[1]);
            Console.WriteLine("Third: " + names[2]);
            Console.WriteLine("Last: " + names[names.Count - 1]);
        }
    }
}
