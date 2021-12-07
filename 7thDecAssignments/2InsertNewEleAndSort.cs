using System;

public class InserteNewElementAndSort
{
    public static void Main(string[] args)
    {
        int[] arr1 = new int[100];

        Console.Write(" Enter size of an array: ");
        int n = int.Parse(Console.ReadLine());
        
        Console.WriteLine(" Enter {0} array elements: ", n);
        for(int i = 0; i< n; i++)
        {
            Console.Write(" ");
            arr1[i] = int.Parse(Console.ReadLine());
        }
        
        Console.Write(" Inseted array elements are: ");
        for(int i = 0; i< n; i++)
        {
            Console.Write(arr1[i]+" ");
        }

        Console.Write("\n Enter new element to insert after then array will get sorted: ");
        int val = int.Parse(Console.ReadLine());
        arr1[n] = val;

        for (int i = 0; i < n + 1; i++) 
        {
            for (int j = i + 1; j < n + 1; j++)
            {
                if(arr1[i] > arr1[j])
                {
                    int temp = arr1[i];
                    arr1[i] = arr1[j];
                    arr1[j] = temp;
                }
            }
        }
       
        Console.Write(" Elements after sort: ");
        for(int i = 0; i < n + 1; i++)
        {
            Console.Write(arr1[i]+" ");
        }
    }
}