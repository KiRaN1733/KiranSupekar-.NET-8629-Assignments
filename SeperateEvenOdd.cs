// Seperate odd and even integers in separate arrays.

using System;

public class SeperateEvenOddNums
{
    public static void Main(string[] args)
    {
        int[] arr1 = new int[100];
        int n, i = 0, m = 0, k = 0;
        int[] even = new int[50];
        int[] odd = new int[50];


        Console.Write(" Enter size of an array: ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine(" Enter {0} array elements: ", n);
        for(i = 0; i < n; i++)
        {
            Console.Write(" ");
            arr1[i] = int.Parse(Console.ReadLine());
        }

        for (i = 0; i < n; i++)
        {
            if (arr1[i] % 2 == 0)
            {
                even[m] = arr1[i];
                m++;
            }
            else
            {
                odd[k] = arr1[i];
                k++;
            }
        }
        Console.Write(" Even numbers in an array: ");
        for (i = 0; i < m; i++)
            Console.Write(even[i] + " ");

        Console.Write("\n Odd numbers in an array: ");
        for (i = 0; i < k; i++)
            Console.Write(odd[i] + " ");
    }
}