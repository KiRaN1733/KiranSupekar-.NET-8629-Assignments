using System;
using System.Collections.Generic;
using System.Linq;

namespace Classes._10thDecAssignments
{
    class _4FreqOfNumsUsingLinq
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 2, 3, 4, 1, 5, 2, 5, 1, 3, 6, 7, 4, 3, 3, 4, 1 };

            var frequencies = from x in arr group x by x into y select y;

            foreach(var frequency in frequencies)
            {
                Console.Write(" Number "+frequency.Key + " appears " + frequency.Count() + " times\n");
            }
        }
    }
}
