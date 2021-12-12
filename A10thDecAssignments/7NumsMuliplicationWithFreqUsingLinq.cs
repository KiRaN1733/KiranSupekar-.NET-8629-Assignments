// Write a program in C# Sharp to display numbers, multiplication of number with frequency and frequency of a number of giving array

using System;
using System.Collections.Generic;
using System.Linq;

namespace Classes._10thDecAssignments
{
    class _7NumsMuliplicationWithFreqUsingLinq
    {
        public static void Main(String[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 4, 3, 2, 5, 6, 4, 7, 6, 7, 4, 5, 4, 5 };

            var freq = from x in arr group x by x into y select y;

            Console.WriteLine(" Number   Number*Frequency   Frequency");
            foreach(var num in freq)
            {
                Console.WriteLine("   " + num.Key + "           " + num.Key * num.Count() + "                " + num.Count());
            }
        }
    }
}
