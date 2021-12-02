// PROGRAM TO PRINT ALL UNIQUE ELEMENTS IN AN ARRAY

using System;

//public class PrintUniqueArrayElements
//{
//    public static void Main(string[] args)
//    {
//        Console.Write(" Enter size of an array: ");
//        int n = int.Parse(Console.ReadLine());

//        int[] arr1 = new int[n];
//        int[] hasUnique = new int[n];

//        Console.WriteLine(" Enter an array elements: ");
//        for(int i = 0; i < n; i++)
//        {
//            Console.Write(" ");
//            arr1[i] = int.Parse(Console.ReadLine());
//            hasUnique[i] = 0;
//        }
//        int noOfUnique = 1;
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                if(arr1[i] == arr1[j])
//                {
//                    hasUnique[j] = noOfUnique;
//                    noOfUnique++;
//                }
//            }
//            noOfUnique = 1;
//        }
//        Console.Write(" Unique elements are: ");
//        for (int i = 0; i < n; i++)
//        {
//            if(hasUnique[i] == 1)
//            {
//                Console.Write(arr1[i]+" ");
//            }
//        }
//        Console.WriteLine("\n");
//    }
//}

class PrintUniqueElements
{
    public static void Main(string[] args)
    {
        Console.Write(" Enter size of an array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr1 = new int[n];
        int[] uniqueElements = new int[n];

        Console.WriteLine(" Enter an array elements: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(" ");
            arr1[i] = int.Parse(Console.ReadLine());
            uniqueElements[i] = 0;
        }

        int noOfUniques = 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (arr1[i] == arr1[j])
                {
                    uniqueElements[j] = noOfUniques;
                    noOfUniques++;
                }
            }
            noOfUniques = 1;
        }

        Console.Write(" Unique elements are: ");
      for (int i = 0; i < n; i++)
        {
            if (uniqueElements[i] == 1)
            {
                Console.Write(arr1[i] + " ");
            }
        }
        Console.WriteLine("\n");
    }
}


