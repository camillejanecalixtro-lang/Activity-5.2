using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("PALINDROME PROGRAM");
        Console.WriteLine("Enter 0 to exit.");

        while (true)
        {
            Console.Write("\nEnter word: ");
            string word = Console.ReadLine();

            if (word == "0")
            {
                Console.WriteLine("Thank you for using the program");
                break;
            }

            Stack<char> letters = new Stack<char>();

            foreach (char ch in word)
            {
                letters.Push(ch);
            }

            string reverseWord = "";

            while (letters.Count > 0)
            {
                reverseWord += letters.Pop();
            }

            if (word.Equals(reverseWord, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("It is PALINDROME");
            }
            else
            {
                Console.WriteLine("It is NOT PALINDROME");
            }
        }
    }
}
