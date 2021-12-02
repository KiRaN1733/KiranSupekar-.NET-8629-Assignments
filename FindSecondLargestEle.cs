// to find second largest element from the array.

using System;

public class SecondLargesElement
{
    public static void Main(string[] args)
    {
        int[] arr1 = new int[100];

        Console.Write(" Enter size of an array: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(" Enter {0} array elements: ", n);
        for (int i = 0; i < n; i++)
        {
            Console.Write(" ");
            arr1[i] = int.Parse(Console.ReadLine());
        }
        Console.Write(" Inserted array elements are: ");
        for(int i = 0; i < n; i++)
        {
            Console.Write(arr1[i]+" ");
        }
        int larg = 0, larg2 = 0, j = 0;
        for(int i = 0; i < n; i++)
        {
            if (larg < arr1[i])
            {
                larg = arr1[i];
                j = i;
            }
        }
        for(int i = 0; i < n; i++)
        {
            if (i == j)
            {
                i = i + 1 - 1; // ignoring largest value;
            }
            else
            {
                if(larg2 < arr1[i])
                {
                    larg2 = arr1[i];
                }
            }
        }
        Console.WriteLine("\n Second largest element is: "+ larg2);
    }
}
