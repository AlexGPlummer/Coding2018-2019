using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        private static List<int> i;

        static void Main(string[] args)
        {
            int[] myIntArray = new int[10];
            List<int> myIntList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Random rand = new Random();
            int myInt;
            for (int i = 0; i < 10; i++)
            {
                myIntList.Add(i);
                Console.WriteLine(i);
            }
            for (int i = myIntList.Count - 1; i > 0; i--)
            {
                myIntList.RemoveAt(i);
            }
            //for (int i = 0; i < 10; i++)
            //{
            //myInt = rand.Next();
            //if (myInt < 10)
            //{
            //myIntArray[i] = myInt;
            //Console.WriteLine(myIntArray[i]);
            //}
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //myInt = rand.Next();
            //myIntList.Add(myInt);
            //Console.WriteLine(myIntList[i]);
            //}


            //int[] myIntList2 = new int[10];


            //for (int i = 0; i < 5; i++)
            //{

            // Console.WriteLine("Enter a number");
            //myInt = int.Parse(Console.ReadLine());
            //myIntList2[i] = myInt;
            //Console.WriteLine(myIntList2[i]);   

            //}
        }
    }
}
