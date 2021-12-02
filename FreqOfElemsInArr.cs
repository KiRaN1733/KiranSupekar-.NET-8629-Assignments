using System;

public class FreqOfElementsInArr
{
    public static void Main(string[] args)
    {
        Console.Write(" Enter size of an array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr1 = new int[n];
        int[] freqArr = new int[n];
        int count = 1;

        Console.WriteLine(" Enter {0} array elements: ", n);
        for (int i = 0; i < n; i++)
        {
            Console.Write(" ");
            arr1[i] = int.Parse(Console.ReadLine());
            freqArr[i] = -1;
        }    
        
        for(int i = 0; i < n; i++)
        {
            count = 1;
            for(int j = i+1; j < n; n++)
            {
                if(arr1[i] == arr1[j])
                {
                    count++;
                    freqArr[i] = 0;
                }
            }
            if(freqArr[i] != 0)
            {
                freqArr[i] = count;
            }
        }
        Console.WriteLine(" Frequency of array elements: ");
        for (int i = 0; i < n; i++)
        {
            if(freqArr[i] != 0)
            {
                Console.WriteLine(" {0} occurs {1} times ", arr1[i], freqArr[i]);
            }
        }
    }
}