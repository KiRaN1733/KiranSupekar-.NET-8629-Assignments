// Write a program in C# Sharp to create a list of numbers and display the numbers greater than 80.

using System;
using System.Collections.Generic;
using System.Linq;

namespace Classes._10thDecAssignments
{
    class _9DisplayNumsGreaterThan80UsingLinq
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(59);
            list.Add(88);
            list.Add(67);
            list.Add(92);
            list.Add(82);
            list.Add(103);
            list.Add(95);

            List<int> filteredList = list.FindAll(x => x > 80 ? true : false);

            Console.Write(" List of numbers greater than 80 are: ");
            foreach(int num in filteredList)
            {
                Console.Write(" " + num);
            }
        }

    }
}
