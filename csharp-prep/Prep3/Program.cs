using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number? ");
        int magicNumber = Console.ReadLine()

        Console.WriteLine("What is your guess? ");
        int guess = Console.ReadLine();

        if guess > magicNumber {
            console.WriteLine("Lower");
        }

        elseif guess < magicNumber {
            console.WriteLine("Higher");
        }

        else guess == magicNumber {
            console.WriteLine("You guessed it! ");
        }
    }
}