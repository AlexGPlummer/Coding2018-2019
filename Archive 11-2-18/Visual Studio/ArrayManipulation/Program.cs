using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int seed = 1234;
            Random rand = new Random(seed);

            //Apply random values of 0-9 to the array. Note: This does not prevent duplicates
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 10);
            }


            int temp = array[0];
            array[0] = array[1];
            array[1] = temp;

            //The following can be used to test your implementations. Uncomment each line as you go to test.
            //NOTE: You don't have to do each line sequentially. For example, implementing the FindMin and FindMax methods
            //will be very useful for your FindRange method. Hint... Hint...

            Console.WriteLine("UNSORTED: ");
            PrintArray(array);
            Console.WriteLine("BUBBLE SORTED: ");
            PrintArray(BubbleSort(array));
            Console.WriteLine("SELECTION SORTED: ");
            PrintArray(SelectionSort(array));
            Console.WriteLine("MEAN: " + FindMean(array));
            Console.WriteLine("MEDIAN: " + FindMedian(SelectionSort(array)));
            Console.WriteLine("RANGE: " + FindRange(array));
            Console.WriteLine("MODE: " + FindMode(array));
            Console.WriteLine("MAX: " + FindMax(array));
            Console.WriteLine("MIN: " + FindMin(array));
        }

        /// <summary>
        /// Prints the array in | x | y | z | a | b | c | format
        /// </summary>
        /// <param name="array">The array to be printed</param>
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("| " + array[i] + " ");
            }
            Console.WriteLine("|");
        }

        /// <summary>
        /// Implements a bubble sort algorithm to sort the array
        /// </summary>
        /// <param name="array">The array to sort</param>
        /// <returns>The sorted array</returns>
        public static int[] BubbleSort(int[] array)
        {
            int[] mutatedArray = new int[array.Length];
            array.CopyTo(mutatedArray, 0);
            int n = mutatedArray.Length;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i < n; i++)
                {
                    if (mutatedArray[i - 1] > mutatedArray[i])
                    {
                        int temp = mutatedArray[i];
                        mutatedArray[i] = mutatedArray[i - 1];
                        mutatedArray[i - 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped == true);
            return mutatedArray;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Implements a selection sort algorithm to sort the array
        /// </summary>
        /// <param name="array">The array to sort</param>
        /// <returns>The sorted array</returns>
        public static int[] SelectionSort(int[] array)
        {
            int[] mutatedArray = new int[array.Length];
            array.CopyTo(mutatedArray, 0);
            int n = mutatedArray.Length;
            int min;
            int count = 0;            
            for (int i = 0; i < n; i++)
            {
                min = mutatedArray[i];
                for (int j = i; j < n; j++)
                {
                    if (min > mutatedArray[j])
                    {
                        min = mutatedArray[j];
                        count = j;                        
                    }
                }
                if (min != mutatedArray[i])
                { 
                    int temp = mutatedArray[i];
                    mutatedArray[i] = min;
                    mutatedArray[count] = temp;
                }
            }
            return mutatedArray;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Finds the mean (average) of the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The mean</returns>
        public static float FindMean(int[] array)
        {
            float mean = 0;
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {

                mean = mean + array[i];

            }
            mean = mean / n;
            return mean;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Finds the median (middle element of sorted array) of the array
        /// In the case that the array is an even length, average the two middle elements
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The median</returns>
        public static double FindMedian(int[] array)
        {
            double median = 0;
            int n = array.Length;
            if (n % 2 == 0)
            {
                int mid1 = array[(n / 2) - 1];
                int mid2 = array[(n / 2)];
                median = (((mid1 + mid2) / 2) + .5);                                
            }
            else
            {
                median = array[(n / 2)];
            } 
            return median;
            //throw new NotImplementedException(); 
        }

        /// <summary>
        /// Finds the range (highest value - lowest value) of the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The range</returns>
        public static int FindRange(int[] array)
        {
            int n = array.Length;
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            int min = array[0];
            for (int i = 0; i < n; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            int range = (max - min);
            return range;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Finds the mode (most common occuring element) of the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The mode</returns>
        public static int FindMode(int[] array)
        {
            int mode = 0;
            int maxCount = 0;
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for(int j = 0; j < i; j++)
                {
                    count = count + 1;
                }
                if(count > maxCount)
                {
                    maxCount = count;
                    mode = array[i];
                }
            }            
            return mode;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Finds the maximum value inside the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The maximum value</returns>
        public static int FindMax(int[] array)
        {
            int n = array.Length;
            int max = 0;
            for (int i = 0; i < n; i++)
            {                
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Finds the minimum value inside the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The minimum value</returns>
        public static int FindMin(int[] array)
        {
            int n = array.Length;
            int min = array[0];
            for (int i = 0; i < n; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
            throw new NotImplementedException();
        }
    }
}
