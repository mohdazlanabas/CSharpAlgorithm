using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Globalization;

namespace AlgoSorting
{
    class Program
    {
        public static void Main(string[] args)
        {

            // ARRAY GENERATOR

            int Min = 0;
            int Max = 100000000;
            int len = 100000000; // array length

            int[] arr = new int[len];
            Random randNum = new Random();
            for (int r = 0; r < arr.Length; r++)
            {
                arr[r] = randNum.Next(Min, Max);
            }

            // BEFORE

            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("\nProcess START! \n");
            Console.WriteLine("Array Length: " + len + "\n");
            stopwatch.Start();

            Console.WriteLine("Binary Search \n");
            Console.WriteLine("Before:");
            // foreach (int x in arr)
               //  Console.Write(x + " ");

            // MAIN PART

            int value = 9999999;

            int index = linearSearch(arr, value);
            if(index != -1)
            {
                Console.WriteLine("\n\nElement found at index: " + index);
            } else
            {
                Console.WriteLine("\n\nElement NOT found");
            }

            // AFTER 

            Console.WriteLine("\nSorted:");
            // foreach (int y in arr)
            //     Console.Write(y + " ");

            stopwatch.Stop();
            Console.WriteLine("\nElasped Time is {0} ms", stopwatch.ElapsedMilliseconds);
            Console.WriteLine("\nProcess END!");

        }
        public static int linearSearch(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

       

    }
}
