// To insert new value in the unsorted array.

using System;

class InsertInUnsortedArray
{
    public static void Main(string[] args)
    {
        int[] arr1 = new int[100];

        Console.Write(" Enter size of an array: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(" Enter {0} array elments: ", n);
        for(int i = 0; i < n; i++)
        {
            Console.Write(" ");
            arr1[i] = int.Parse(Console.ReadLine());
        }
        Console.Write(" Array Before Inserted Value: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr1[i] + " ");
        }
        Console.Write("\n Enter new value to insert in array: ");
        int val = int.Parse(Console.ReadLine());
        Console.Write(" Enter index at which do you want to insert: ");
        int p = int.Parse(Console.ReadLine());

        for(int i = n; i >= p; i--)
        {
            arr1[i] = arr1[i - 1];
        }
        arr1[p] = val;
        Console.Write(" Array After Inserted new Value: ");
        for (int i = 0; i <= n; i++)
        {
            Console.Write(arr1[i] + " ");
        }
    }
}