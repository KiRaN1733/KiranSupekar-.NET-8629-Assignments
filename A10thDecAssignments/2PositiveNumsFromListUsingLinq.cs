// Write a program in C# Sharp to find the +ve numbers from a list of numbers using two where conditions in LINQ Query

using System;
using System.Collections.Generic;
using System.Linq;

namespace Classes._10thDecAssignments
{
    class _2PositiveNumsFromListUsingLinq
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, -4, 5, 6, -4, -5, -2, 9, 16, 28, 19, 20, -7 };

            var Nums = from varName in arr where varName > 0 where varName < 20 select varName;

            Console.Write(" The numbers within the range of 1 to 20 are:");
            foreach(var PositiveNums in Nums)
            {
                Console.Write(" " + PositiveNums);
            }
        }
    }
}
