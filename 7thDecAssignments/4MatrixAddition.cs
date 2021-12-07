using System;

public class MatrixAddition
{
    public static void Main(string[] args)
    {
        Console.WriteLine(" Addition of matrices.");
        Console.Write(" Enter no.of rows: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write(" Enter no.of columns: ");
        int n = int.Parse(Console.ReadLine());

        int[,] arr1 = new int[m,n];
        int[,] arr2 = new int[m,n];

        Console.WriteLine(" Enter elements of first Matrix: ");
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                Console.Write(" Element- [{0}] [{1}]: ", i, j);
                arr1[i,j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine(" Enter elements of second Matrix: ");
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                Console.Write(" Element- [{0}] [{1}]: ", i, j);
                arr2[i,j] = int.Parse(Console.ReadLine());
            }
        }

        Console.Write("\n The first Matrix is: ");
        for(int i = 0; i < m; i++)
        {
            Console.WriteLine();
            Console.Write(" |");
            for(int j = 0; j < n; j++)
            {
                Console.Write(" " + arr1[i,j]);
            }
            Console.Write(" |");

        }
        Console.Write("\n\n The Second matrix is: ");
        for (int i = 0; i < m; i++)
        {
            Console.WriteLine();
            Console.Write(" |");
            for(int j = 0; j < n; j++)
            {
                Console.Write(" " + arr2[i,j]);
            }
            Console.Write(" |");

        }
        Console.WriteLine("\n");

        // Addition of matrices.
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                arr2[i, j] += arr1[i, j];
            }
        }
        Console.WriteLine(" Representation of matrics after addition: ");
        for (int i = 0; i < m; i++)
        {
            Console.WriteLine();
            Console.Write(" |");
            for (int j = 0; j < n; j++)
            {
                Console.Write(" " + arr2[i, j]);
            }
            Console.Write(" |");

        }
        Console.WriteLine("\n");
    }
}