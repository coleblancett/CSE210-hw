using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

        if (guess > magicNumber) {
            Console.WriteLine("Lower");
        }

        else if (guess < magicNumber) {
            Console.WriteLine("Higher");
        }

        else { 
            Console.WriteLine("You guessed it! "); 
        }
    }
}