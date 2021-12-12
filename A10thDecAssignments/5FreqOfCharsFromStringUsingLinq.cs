// Write a program in C# Sharp to display the characters and frequency of character from giving string. 

using System;
using System.Collections.Generic;
using System.Linq;

namespace Classes._10thDecAssignments
{
    class _5FreqOfCharsFromStringUsingLinq
    {
        public static void Main(string[] args)
        {
            Console.Write(" Enter a string: ");
            string str = Console.ReadLine();

            var freq = from x in str group x by x into y select y;

            foreach(var ch in freq)
            {
                if (ch.Key != ' ')
                    Console.WriteLine(" Character " + ch.Key + " appears " + ch.Count() + " times");
            }
        }
    }
}
