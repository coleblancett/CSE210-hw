using System;
public abstract class Activity
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int Duration { get; private set; }

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public virtual void Start()
    {
        Console.WriteLine($"Starting {Name} activity. {Description}");
        Console.Write("Please enter the duration of the activity in seconds: ");
        Duration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    public virtual void End()
    {
        Console.WriteLine("You have done a good job!");
        Thread.Sleep(3000); // Pause for 3 seconds
        Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds.");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    public abstract void Execute();
}