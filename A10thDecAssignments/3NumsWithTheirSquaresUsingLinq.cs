// Write a program in C# Sharp to find the number of an array and the square of each number. 

using System;
using System.Collections.Generic;
using System.Linq;

namespace Classes._10thDecAssignments
{
    class _3NumsWithTheirSquaresUsingLinq
    {
        public static void Main(string[] args)
        {
            var arr1 = new[] { 3, 9, 2, 8, 6, 5 };

            var sqNo = from int Number in arr1
                       let SqrNo = Number * Number
                       where SqrNo > 20
                       select new { Number, SqrNo };

            foreach (var a in sqNo)
                Console.WriteLine(a);
        }
    }
}
