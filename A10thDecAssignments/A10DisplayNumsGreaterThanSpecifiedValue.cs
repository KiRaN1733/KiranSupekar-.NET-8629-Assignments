// Write a program in C# Sharp to accept the members of a list through the keyboard and display the members more than a specific value.

using System;
using System.Collections.Generic;
using System.Linq;

namespace Classes._10thDecAssignments
{
    class A10DisplayNumsGreaterThanSpecifiedValue
    {
        public static void Main(string[] args)
        {
            try
            {
                List<int> list = new List<int>();
                Console.Write(" Enter the number of members in the list: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(" Enter {0} numbers in list: ", n);
                for(int i = 0; i<n; i++)
                {
                    Console.Write(" number-{0}: ", i + 1);
                    list.Add(int.Parse(Console.ReadLine()));
                }
                Console.Write(" Enter the value above which you want to display the numbers of the list: ");
                int num = int.Parse(Console.ReadLine());

                List<int> filteredList = list.FindAll(x => x > num ? true : false);

                Console.WriteLine(" The numbers greater than {0} are: ",num);
                foreach(int nums in filteredList)
                {
                    Console.WriteLine(" " + nums);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(" Exception: " + ex.Message);
            }
        }
    }
}
