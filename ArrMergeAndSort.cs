using System;

public class ArrayMergeAndSort
{
    public static void Main(string[] args)
    {
        Console.Write(" Enter size of first array: ");
        int m = int.Parse(Console.ReadLine());
        int[] arr1 = new int[m];

        Console.WriteLine(" Enter {0} array elements: ", m);
        for (int i = 0; i < m; i++)
        {
            Console.Write(" Element - {0}: ", i + 1);
            arr1[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("\n Enter size of second array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr2 = new int[n];

        Console.WriteLine(" Enter {0} array elements: ", n);
        for (int i = 0; i < n; i++)
        {
            Console.Write(" Element- {0}: ", i + 1);
            arr2[i] = int.Parse(Console.ReadLine());
        }

        // Merging of two arrays starts

        int[] SortedArray = new int[m + n];
        for (int i = 0; i < m; i++)
        {
            SortedArray[i] = arr1[i];
        }

        for (int i = 0; i < n; i++)
        {
            SortedArray[i + m] = arr2[i];
        }
        //Merging completed.

        //Sorting starts
        int count = 0;
        int swapCount = 0;
        for (int i = 0; i < m + n; i++)
        {
            for (int j = 0; j < m + n - 1; j++)
            {
                if (SortedArray[j] >= SortedArray[j + 1])
                {
                    int temp = SortedArray[j];
                    SortedArray[j] = SortedArray[j + 1];
                    SortedArray[j + 1] = temp;
                    swapCount++;
                }
                count++;
            }
        }
        //Sorting completed: bubble sort
        //Printing sorted array.
        Console.Write(" Elements after sort: ");
        for (int i = 0; i < m + n; i++)
        {
            Console.Write(SortedArray[i] + " ");
        }
        Console.WriteLine(" count: {0}, swapCount: {1}.", count, swapCount);
    }
}

//using System;
//public class Exercise7
//{
//    public static void Main()
//    {
//        int[] arr1 = new int[100];
//        int[] arr2 = new int[100];
//        int[] arr3 = new int[200];
//        int s1, s2, s3;
//        int i, j, k, count = 0, swapCount = 0;



//        Console.Write("\n\nMerge two arrays of same size sorted in ascending order.\n");
//        Console.Write("------------------------------------------------------------\n");

//        Console.Write("Input the number of elements to be stored in the first array :");
//        s1 = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Input {0} elements in the array :\n", s1);
//        for (i = 0; i < s1; i++)
//        {
//            Console.Write("element - {0} : ", i);
//            arr1[i] = Convert.ToInt32(Console.ReadLine());
//        }


//        Console.Write("Input the number of elements to be stored in the second array :");
//        s2 = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Input {0} elements in the array :\n", s2);
//        for (i = 0; i < s2; i++)
//        {
//            Console.Write("element - {0} : ", i);
//            arr2[i] = Convert.ToInt32(Console.ReadLine());
//        }

//        /* size of merged array is size of first array and  size of second array */
//        s3 = s1 + s2;

//        /*----------------- insert in the third array------------------------------------*/
//        for (i = 0; i < s1; i++)
//        {
//            arr3[i] = arr1[i];
//        }
//        for (j = 0; j < s2; j++)
//        {
//            arr3[i] = arr2[j];
//            i++;
//        }
//        /*----------------- sort the array in ascending order ---------------------------*/
//        for (i = 1; i <= s3; i++)
//        {
//            for (k = 0; k < s3 - 1; k++)
//            {

//                if (arr3[k] >= arr3[k + 1])
//                {
//                    j = arr3[k + 1];
//                    arr3[k + 1] = arr3[k];
//                    arr3[k] = j;
//                    swapCount++;
//                }
//                count++;
//            }

//        }
//        /*--------------- Prints the merged array ------------------------------------*/
//        Console.Write("\nThe merged array in ascending order is :\n");
//        for (i = 0; i < s3; i++)
//        {
//            Console.Write("{0} ", arr3[i]);
//        }
//        Console.WriteLine(" count: {0}, swapCount: {1}.", count, swapCount);
//        Console.Write("\n\n");
//    }
//}