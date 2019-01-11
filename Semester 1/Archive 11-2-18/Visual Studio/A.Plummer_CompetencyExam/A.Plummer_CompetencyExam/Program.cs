using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Plummer_CompetencyExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            while (answer != -1)
            {
                Console.WriteLine("*************************************************************");
                Console.WriteLine("** Enter the integer value for the action you want to perform");
                Console.WriteLine("** 1. Conditionals");
                Console.WriteLine("** 2. For Loops");
                Console.WriteLine("** 3. While Loops");
                Console.WriteLine("** 4. Arrays");
                Console.WriteLine("** 5. Lists");
                Console.WriteLine("**-1. Exit the program");
                Console.WriteLine("*************************************************************");
                answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    /*
                     * The user will be prompted for user input for their grade, and their reading grade level. Upon input, the 
                     * program will tell the user if they are in high school and read proficiently, if they are in middle school and
                     * read proficiently, if they are in elementary school and read proficiently, or if they do not read 
                     * proficiently. Reading proficiency is calculated by gradeLevel <= readingProficiencyLevel.
                     */
                    int gradeLevel = 0;
                    int readingLevel = 0;
                    Console.Write("Enter your grade level: ");
                    gradeLevel = int.Parse(Console.ReadLine());
                    Console.Write("Enter your reading grade level: ");
                    readingLevel = int.Parse(Console.ReadLine());
                    if (gradeLevel >= 9 && gradeLevel <= readingLevel)
                    {
                        Console.WriteLine("You are in high school and can read proficiently");
                    }
                    if (gradeLevel >= 9 && gradeLevel > readingLevel)
                    {
                        Console.WriteLine("You are in high school and don't read proficiently, go read a book ya fool");
                    }
                    else if (gradeLevel >= 6 && gradeLevel <= readingLevel && gradeLevel < 9)
                    {
                        Console.WriteLine("You are in middle school and can read proficiently");
                    }
                    else if (gradeLevel >= 6 && gradeLevel > readingLevel && gradeLevel < 9)
                    {
                        Console.WriteLine("You are in middle school and don't read proficiently, go read a book ya fool");
                    }
                    else if (gradeLevel >= 1 && gradeLevel <= readingLevel && gradeLevel < 6)
                    {
                        Console.WriteLine("You are in elementry school and can read proficiently");
                    }
                    else if (gradeLevel >= 1 && gradeLevel > readingLevel && gradeLevel < 6)
                    {
                        Console.WriteLine("You are in elemetry school and don't read proficiently, go read a book ya fool");
                    }
                }

                if (answer == 2)
                {
                    /*
                     * Prompt the user for a number to countBy, and a number to countTo. Then, using a for loop, count to
                     * countTo by countBy. Example output is as follows: countBy = 3, countTo = 15… 0,3,6,9,12,15.
                     */
                    int countBy = 0;
                    int countTo = 0;
                    Console.Write("Enter a number to count by: ");
                    countBy = int.Parse(Console.ReadLine());
                    Console.Write("Enter a number to count up to by " + countBy + ": ");
                    countTo = int.Parse(Console.ReadLine());                   
                    for (int count = 0; count <= countTo; count = count + countBy)
                    {
                        Console.WriteLine(count);
                    }
                }

                if (answer == 3)
                {
                    /*
                     * Create an int variable that stores the sum of the user input. Then allow the user to input integer values
                     * to add to the sum. When the user enters 0, it will get out of the loop and tell the user their final total.
                     */
                    int sum = 0;
                    int imput = 1;
                    while (imput != 0)
                    {
                        Console.WriteLine("Our sum starts at 0. Enter interger values to add to, and print the sum. Enter 0 to stop adding.");
                        Console.Write("Enter a value: ");
                        imput = int.Parse(Console.ReadLine());
                        if (imput != 0)
                        {                        
                            sum = imput + sum;
                            Console.WriteLine("new sum = " + sum);
                        }
                    }
                    Console.WriteLine("Final total " + sum);
                }

                if (answer == 4)
                {
                    /*
                     * Create an array of ints, size 10. Add user input to a for loop that iterates through the array and puts the 
                     * input in that index. If the user enters 1,2,3,4,5,6,7,8,9,0 then that will be the values in the array. After 
                     * they have entered all 10 values, print the values to the user.
                     */
                    int[] arrayofInts = new int[10];
                    Console.WriteLine("You have an array of size 10 and of type int. Enter values to populate the array.");
                    for (int i = 0; i <= 10; i++)
                    {
                        arrayofInts[i] = int.Parse(Console.ReadLine());
                        Console.WriteLine(arrayofInts[i] + " successfully added");
                    }
                    Console.WriteLine("All array values added. Here they are!");
                    for (int i = 0; i <= 10; i++)
                    {
                        Console.WriteLine("index " + i + " = " + arrayofInts[i]);
                    }
                }

                if (answer == 5)
                {
                    /*
                    * Create a list of strings, and continuously allow the user to add new strings to the list until they enter 
                    * “end”. Upon the ending string, print out the elements of the list to the user. 
                    */
                    List<string> listofStrings = new List<string>();
                    string userimput = "";
                    Console.WriteLine("You have a list of type string. Enter values to add to the list.");
                    Console.WriteLine("Type end to stop adding and to print out your list.");
                    int run = 0;
                    while ( userimput != "end")
                    {
                        Console.Write("Enter a string: ");
                        userimput = Console.ReadLine();
                        if (userimput != "end")
                        {
                            listofStrings.Add(userimput);
                            run = run + 1;
                        }    
                    }
                    for (int i = 0; i < run; i++)
                    {
                        Console.WriteLine("index " + i + " = " + listofStrings[i]);
                    }
                }
            }
        }
    }
}
