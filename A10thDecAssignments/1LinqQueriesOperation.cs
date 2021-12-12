// Write a program in C# Sharp to shows how the three parts of a query operation execute. 
// 3 parts of Query execution is: 
//      1) Data source
//      2) Query Creation
//      3) Query Execution


using System;
using System.Collections.Generic;
using System.Linq;

namespace Classes._10thDecAssignments
{
    class _1LinqQueriesOpertion
    {
        public static void Main(string[ ] args)
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // Data source

            var nums = from varName in arr where varName % 2 == 0 select varName; // Query Creation

            Console.Write(" The numbers divisible by 2 are: ");
            foreach(var varName in nums)  // Query Execution
            {
                Console.Write(" " + varName);
            }
        }
    }
}
