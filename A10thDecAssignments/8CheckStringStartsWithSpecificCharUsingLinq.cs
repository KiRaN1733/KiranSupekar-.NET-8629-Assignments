// Write a program in C# Sharp to find the string which starts and ends with a specific character.

using System;
using System.Collections.Generic;
using System.Linq;

namespace Classes._10thDecAssignments
{
    class _8CheckStringStartsWithSpecificCharUsingLinq
    {
        public static void Main(String[] args)
        {
            string[] cities = new string[] { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            char ch;
            string start, end;

            try
            {
                Console.Write(" Enter Starting Character: ");
                ch = Convert.ToChar(Console.ReadLine());
                start = ch.ToString();

                Console.Write(" Enter Ending Character: ");
                ch = Convert.ToChar(Console.ReadLine());
                end = ch.ToString();

                var names = from city in cities where city.StartsWith(start) where city.EndsWith(end) select city;
                foreach (var name in names)
                {
                    Console.WriteLine(" " + name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Exception: " + ex.Message);
            }
        }
    }
}
