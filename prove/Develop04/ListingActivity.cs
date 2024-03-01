using System;
public class ListingActivity : Activity
{
    private string[] prompts = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    public override void Execute()
    {
        Start();
        Random random = new Random();
        List<string> items = new List<string>();
        for (int i = 0; i < Duration; i++)
        {
            Console.WriteLine(prompts[random.Next(prompts.Length)]);
            Console.WriteLine("Start listing items:");
            string item = Console.ReadLine();
            items.Add(item);
            Thread.Sleep(1000); // Pause for 1 second
        }
        Console.WriteLine($"You have listed {items.Count} items.");
        End();
    }
}