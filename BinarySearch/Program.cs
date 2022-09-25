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
            int Max = 6;
            int len = 100; // array length

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

            Console.WriteLine(" # USE COUNT # Sort \n");
            Console.WriteLine("Before:");
            foreach (int x in arr)
                Console.Write(x + " ");

            // MAIN PART

            int[] sortedArray = new int[arr.Length];

            int minVal = arr[0];
            int maxVal = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < minVal)
                    minVal = arr[i];
                else if (arr[i] > maxVal)
                    maxVal = arr[i];
            }

            int[] counts = new int[maxVal - minVal + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                counts[arr[i] - minVal]++;
            }

            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                sortedArray[counts[arr[i] - minVal]--] = arr[i];
            }

            // AFTER 

            Console.WriteLine("\nSorted:");
            foreach (int y in sortedArray)
                Console.Write(y + " ");

            stopwatch.Stop();
            Console.WriteLine("\nElasped Time is {0} ms", stopwatch.ElapsedMilliseconds);
            Console.WriteLine("\nProcess END!");

            int[] v = sortedArray;
            int To_Find;
            To_Find = 5;
            binarySearch(v, To_Find);
        }

        public static void binarySearch(int[] v, int To_Find)
        {
            int lo = 0;
            int hi = v.Length - 1;
            int mid;

            while (hi - lo > 1)
            {
                mid = (hi + lo) / 2;
                if (v[mid] < To_Find)
                {
                    lo = mid + 1;
                } else
                {
                    hi = mid;
                }
            }

            if (v[lo] == To_Find)
            {
                Console.WriteLine("Found At Index: " + lo);
            } else if (v[hi] == To_Find)
            {
                Console.WriteLine("Found At Index: " + hi);
            } else
            {
                Console.WriteLine("Not Found!");
            }

        }

    }
}
