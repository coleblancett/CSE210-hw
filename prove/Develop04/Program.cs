using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("Welcome to the Activity Program!");
        Console.WriteLine("Please select an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.Write("Your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        Activity activity;
        switch (choice)
        {
            case 1:
                activity = new BreathingActivity();
                break;
            case 2:
                activity = new ReflectingActivity();
                break;
            case 3:
                activity = new ListingActivity();
                break;
            default:
                Console.WriteLine("Invalid choice. Exiting program.");
                return;
        }

        activity.Execute();
    }
}