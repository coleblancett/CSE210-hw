using System;
public class ReflectingActivity : Activity
{
    private string[] prompts = new string[]
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") { }

    public override void Execute()
    {
        Start();
        Random random = new Random();
        for (int i = 0; i < Duration; i++)
        {
            Console.WriteLine(prompts[random.Next(prompts.Length)]);
            Thread.Sleep(1000); // Pause for 1 second
        }
        End();
    }
}