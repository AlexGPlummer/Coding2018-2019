using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine(stringTimesMethod("Hi", 3));
        }

        static void intersect()
        {
            List<int> l1 = new List<int>() { 8, 6, 7, 5, 3, 0, 9 };
            List<int> l2 = new List<int>() { 3, 2, 2, 8, 0, 4, 7 };
            List<int> l3 = l1.Intersect(l2).ToList();

            /*for (int i = 0; i < l1.Count; i++)
            {
                if (l2.Contains(l1[i]))
                {
                    l3.Add(l1[i]);
                }
            }*/

            for (int i = 0; i < l3.Count; i++)
            {
                Console.WriteLine(l3[i]);
            }
        }

        static void where()
        {
            List<int> l1 = new List<int>() { 8, 6, 7, 5, 3, 0, 9 };
            List<int> l2 = l1.Where(t => t >= 5).ToList();

            /*for (int i = 0; i < l1.Count; i++)
            {
                if (l1[i] >= 5)
                {
                    l2.Add(l1[i]);
                }
             }*/

            for (int i = 0; i < l2.Count; i++)
            {
                Console.WriteLine(l2[i]);
            }
        }

        static string stringTimesMethod(string stringTimes, int i)
        {
            string eh = stringTimes;
            for(int j = 1; j < i; j++)
            {
                stringTimes = stringTimes + eh;
            }
            return stringTimes;
        }
    }
}
