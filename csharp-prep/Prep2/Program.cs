using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! What is your grade percentage? ");
        string grade = Console.ReadLine();
        int letter = int.Parse(grade);

        if (letter >= 90)
        {
            Console.Write("You got an A!");
        }
        else if (letter < 90 && letter >= 80)
        {
            Console.Write("You got a B!");
        }
        else if (letter < 80 && letter >= 70)
        {
            Console.Write("You got a C!");
        }
        else if (letter < 70 && letter >= 60)
        {
            Console.Write("You got a D!");
        }
        else if (letter < 60)
        {
            Console.Write("You got an F!");
        }
    }
}