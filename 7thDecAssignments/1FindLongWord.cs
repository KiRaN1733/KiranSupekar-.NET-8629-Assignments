using System;

class LongestWord
{
    public static void Main(string[] args)
    {
        Console.Write(" Enter a string with multiple words: ");
        string str = Console.ReadLine();
        string[] words = str.Split(new[] { " " }, StringSplitOptions.None);
        string longWord = "";
        int ctr = 0;
        foreach (string s in words)
        {
            if (s.Length > ctr)
            {
                longWord = s;
                ctr = s.Length;
            }
        }
        Console.WriteLine(" Longest word in a string is: {0}", longWord);
    }
}
