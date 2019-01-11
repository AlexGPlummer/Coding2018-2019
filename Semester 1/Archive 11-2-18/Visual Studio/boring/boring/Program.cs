using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boring
{
    class Program
    {
        static int Q;
        static int R;
        static int divide;
        static int num;
        static void Main(string[] args)
        {
            Console.Write("Enter the number you want to divide: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Enter the number you want to divide by: ");
            divide = int.Parse(Console.ReadLine());
            anyRadixPrint(num, divide);
        }
        static void anyRadixPrint(int num, int divide)
        {
            Q = num / divide;
            R = num % divide;
            if (Q != 0)
            {
                anyRadixPrint(Q, divide);
            }            
            char c = (char)('0' + R);                 
            Console.WriteLine(c);            
        }         
    }
}
