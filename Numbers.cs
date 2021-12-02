//sum of Prime numbers between given range.
//sum of no.of first n prime numbers
//sum of Prime numbers upto n

//Factors
//Prime Number
//Composite Number
//Perfect Number
//Abundant Number
//Deficient Number
//Pronic Number

using System;

// SUM OF PRIME NUMBERS BETWEEN GIVEN RANGE.

class SumOfPrimeBetnRange
{
    public static void Main(string[] args)
    {
        Console.Write(" Enter starting number: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write(" Enter endpoint number: ");
        int max = int.Parse(Console.ReadLine());
        int howManyPrimes = 0;

        int Sum = 0;
        for (int i = min; i <= max; i++)
        {
            if (isPrime(i))
            {
                Sum += i;
                howManyPrimes++;
            }
                
        }
        Console.WriteLine(" Sum of {3} Prime numbers between {0} and {1} is: {2}", min, max, Sum,howManyPrimes);

        bool isPrime(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    count++;
            }
            if (count == 2)
                return true;
            else
                return false;
        }

    }
}



/*
// SUM OF PRIME NUMBERS UPTO n.

class SumOfPrimeNums
{
    public static void Main(string[] args)
    {
        Console.Write(" Enter a number to get sum of prime numbers upto n: ");
        int n = int.Parse(Console.ReadLine());

        long Sum = 0;
        for(int i = 1; i<= n; i++)
        {
            if (isPrime(i))
                Sum += i;
        }
        Console.WriteLine(" Sum of prime numbers upto {0} is: {1}", n, Sum);

        
        bool isPrime(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    count++;
            }
            return count == 2 ? true : false;
        }
    }
}
*/

/*
// TO FIND FACTORS OF A NUMBER.

class FactorsOFNum
{
    public static void Main(string[] args)
    {
        Console.Write(" Enter a number to find its factors: ");
        int n = int.Parse(Console.ReadLine());

        for(int i = 1; i <= n; i++)
        {
            if(n%i == 0)
            {
                Console.Write(" "+i);
            }
        }
        Console.WriteLine(" are the factors of {0}.",n);
    }
}
*/

/*
//  CHECK IF THE NUMBER IS PRIME OR NOT.

public class CheckPrimeOrNot
{
    public static void Main()
    {
        Console.Write("Enter a number to check it is prime or not: ");
        int n = Int32.Parse(Console.ReadLine());

        int count = 0;
        for (int i = 1; i <= n/2; i++)
        {
            if(n % i == 0)
            {
                count++;
            }
        }
        Console.WriteLine(" {0} {1} a Prime Number", n, count<=2 ? "Is" : "Is NOT");
    }
}
*/


/*
// CHECK IF THE NUMBER IS COMPOSITE NUMBER OR NOT.
// Composite Number:- number have more than one factor. (excl. 1, n)
public class CheckCompositeNum
{
    public static void Main()
    {
        Console.Write("Enter a number to check it is composite or not: ");
        int n = Int32.Parse(Console.ReadLine());

        int count = 0;
        for (int i = 1; i <= n; i++)
        {
            if(n % i == 0)
            {
                count++;
            }
        }
        if (count > 3)   //1, num itself, more than 1 i.e. 2 ===> 1+1+2 > 3.
            Console.WriteLine(" {0} is a composite number.",n);
        else
            Console.WriteLine(" {0} is not a composite number.",n);
    }
}
*/

/*
// CHECK IF THE NUMBER IS PERFECT OR NOT.
// Perfect Number:- number is equal to sum of its factors except itself.
//e.g.: 6 = 1 + 2 + 3. 

public class CheckPerfectNum
{
    public static void Main(string[] args)
    {
        Console.Write(" Enter number to check it is perfect or not: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        for(int i = 1; i < n; i++)
        {
            if(n % i == 0)
            {
                sum += i;
            }
        }
        if (sum == n)
            Console.WriteLine(" {0} is a perfect number.", n);
        else
            Console.WriteLine(" {0} is not a perfect number.", n);
    }
}
*/


/*
// CHECK IF THE NUMBER IS ABUNDANT OR NOT.
// Abundant Numer:- sum of factors is greater than number itself.
//NOTE: if sum is less than number then the number is called as Deficient number.
class CheckAbundantNum
{
    public static void Main(string[] args)
    {
        Console.Write(" Enter a number to check if it is Abundant or not: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        for(int i = 1; i < n; i++)
        {
            if (n % i == 0)
            {
                sum += i;
            }
        }
        if (sum > n)    // (sum < n) for deficient numer.
            Console.WriteLine(" {0} is an Abundant number.", n);
        else
            Console.WriteLine(" {0} is not an Abundant number.", n);
    }
}
*/

/*
// CHECK IF THE NUMBER IS PRONIC OR NOT.
// Pronic Number: number is product of two consecutive integers.
// e.g.: 56 = 7 * 8; i.e. n(n+1);

public class CheckPronicNum
{
    public static void Main(string[] args)
    {
        Console.Write(" Enter a number to check if it is Pronic or not: ");
        int n = int.Parse(Console.ReadLine());

        int fact = 0;
        for(int i = 1; i < n; i++)
        {
            if (n % i == 0)
                if (i * (i + 1) == n)
                    fact = i;
        }
        Console.Writeline("{0} {1} a pronic Number.", n, fact != 0 ?"is":"is not");
    }
}
*/