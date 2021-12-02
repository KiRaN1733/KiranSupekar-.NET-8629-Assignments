// Delete array element from given index.

using System;

public class DeleteEleFromArray
{
    public static void Main(string[] args)
    {
        int[] arr1 = new int[100];
        Console.Write(" Enter size of an array: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(" Enter {0} array elements: ",n);
        for (int i = 0; i < n; i++)
        {
            Console.Write(" ");
            arr1[i] = int.Parse(Console.ReadLine());
        }
        Console.Write(" Inserted array elements are: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr1[i] + " ");
        }
        Console.Write("\n Enter an element that you want to remove: ");
        int val = int.Parse(Console.ReadLine());
        int p = -1;
        for (int i = 0; i < n; i++)    
        {
            if(arr1[i] == val)
            {
                p = i;
                break;
            }
        }
        for (int i = p; i < n; i++)
        {
            arr1[i] = arr1[i + 1];
        }
        Console.Write(" Array after removed {0} : ", val);
        for(int i = 0; i < n-1; i++)
        {
            Console.Write(arr1[i] + " ");
        }
    }
}
