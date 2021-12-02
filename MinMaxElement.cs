// Find maximum and minimum elements in an array.

using System;

public class MinMaxElement
{
    public static void Main(string[] args)
    {
        int[] arr1 = new int[100];
        int i, n, min, max;

        Console.Write(" Enter size of an array: ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine(" Enter {0} array elements: ", n);
        for (i = 0; i < n; i++)
        {
            Console.Write(" ");
            arr1[i] = int.Parse(Console.ReadLine());
        }

        min = arr1[0];
        max = arr1[0];

        for (i = 1; i < n; i++)
        {
            if (min < arr1[i])
                min = arr1[i];

            if (max > arr1[i])
                max = arr1[i];
        }
        Console.WriteLine(" Minimum num of an array is: " + min);
        Console.WriteLine(" Maximum num of an array is: " + max);
    }
}