using System;
using System.ComponentModel;

namespace Hashing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string[] values = new string[50];
            string str;
            string[] keys = new string[] {"Alphabets",
                "Roman", "Numbers", "Alphanumeric", "Tallypoints"};
            int hashCode;
            for (int k=0; k<5; k++)
            {
                str = keys[k];
                hashCode = HashFunction(str, values);
                values[hashCode] = str;
            }
            for (int k = 0; k < (values.GetUpperBound(0)); k++)
            {
                if (values[k] != null)
                    Console.WriteLine(k + " " + values[k]);
            }
        }
        static int HashFunction(string s, string[] array)
        {
            int total = 0;
            char[] c;
            c = s.ToCharArray();
            for (int k = 0; k <= c.GetUpperBound(0); k++)
                total += (int)c[k];
            return total % array.GetUpperBound(0);
        }
    }
}