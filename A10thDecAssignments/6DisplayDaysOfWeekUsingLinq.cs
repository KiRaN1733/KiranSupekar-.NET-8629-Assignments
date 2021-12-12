// Write a program in C# Sharp to display the name of the days of a week. 

using System;
using System.Collections.Generic;
using System.Linq;

namespace Classes._10thDecAssignments
{
    class _6DisplayDaysOfWeekUsingLinq
    {
        public static void Main(String[] args)
        {
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };


            var weekDays = from Day in days select Day;

            Console.WriteLine(" Days of the Week: ");
            int i = 0;
            foreach (var day in weekDays)
            {
                Console.WriteLine(" "+(++i)+") "+day);
            }
        }
    }
}
