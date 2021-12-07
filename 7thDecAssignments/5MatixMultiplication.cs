using System;

class MatrixMultiplication
{
    public static void Main(string[] args)
    {
        Console.WriteLine("..............Matrix Multiplication................");
        int[,] arr1 = new int[50, 50];
        int[,] arr2 = new int[50, 50];
        int[,] arr3 = new int[50, 50];
        int i, j, k, r1, c1, r2, c2, sum = 0;
        Console.WriteLine(" Enter size of rows and columns of first Matrix: ");
        Console.Write(" Rows: ");
        r1 = int.Parse(Console.ReadLine());
        Console.Write(" Columns: ");
        c1 = int.Parse(Console.ReadLine());
        Console.WriteLine(" Enter size of rows and columns of second Matrix: ");
        Console.Write(" Rows: ");
        r2 = int.Parse(Console.ReadLine());
        Console.Write(" Columns: ");    
        c2 = int.Parse(Console.ReadLine());
        Console.WriteLine(" Enter elements of the first Matrix: ");
        for (i = 0; i < r1; i++)
        {
            for (j = 0; j < c1; j++)
            {
                Console.Write(" Element- [{0}][{1}]: ", i, j);
                arr1[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine(" Enter elements of the second Matrix: ");
        for (i = 0; i < r2; i++)
        {
            for (j = 0; j < c2; j++)
            {
                Console.Write(" Element- [{0}][{1}]: ", i, j);
                arr2[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.Write(" The first Matrix is: ");
        for (i = 0; i < r1; i++)
        {
            Console.WriteLine();
            Console.Write(" |");
            for (j = 0; j < c1; j++)
            {
                Console.Write(" " + arr1[i, j]);
            }
            Console.Write(" |");
        }
        Console.Write("\n\n The second Matrix is: ");
        for (i = 0; i < r2; i++)
        {
            Console.WriteLine();
            Console.Write(" |");
            for (j = 0; j < c2; j++)
            {
                Console.Write(" " + arr2[i, j]);
            }
            Console.Write(" |");
        }
        //Logic starts
        for (i = 0; i < r1; i++)
            for (j = 0; j < c2; j++)
                arr3[i, j] = 0;
        for (i = 0; i < r1; i++)
        {
            for (j = 0; j < c2; j++)
            {
                sum = 0;
                for (k = 0; k < c1; k++)
                {
                    sum = sum + arr1[i, k] * arr2[k, j];
                }
                arr3[i, j] = sum;
            }
        }
        Console.Write("\n\n Representation of an Matrix after Multiplication: ");
        for (i = 0; i < r1; i++)
        {
            Console.WriteLine();
            Console.Write(" |");
            for (j = 0; j < c2; j++)
            {
                Console.Write(" " + arr3[i, j]);
            }
            Console.Write(" |");
        }
        Console.WriteLine("\n");
    }
}