// Sorts element in ascending order.

using System;
class SortInAscending
{
    public static void Main(string[] args)
    {
        int[] arr1 = new int[100];

        Console.Write(" Enter size of an array: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(" Enter {0} array elements: ", n);
        for (int i = 0; i < n; i++)
        {
            Console.Write(" Element-{0}: ",i+1);
            arr1[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr1[i] > arr1[j])
                {
                    int temp = arr1[i];
                    arr1[i] = arr1[j];
                    arr1[j] = temp;
                }
            }
        }

        Console.Write(" Sorted array elements are: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr1[i] + " ");
        }
    }
}

