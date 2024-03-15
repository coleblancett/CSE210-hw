using System;

class Program
{
    static void Main(string[] args)
    {
        User user = new User { Name = "John Doe" };

        while (true)
        {
            Console.WriteLine($"Points: {user.Score}");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Events");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select a choice from the menu:");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter goal name:");
                    var name = Console.ReadLine();
                    Console.WriteLine("Enter goal type (1 for Simple, 2 for Eternal, 3 for Checklist):");
                    var type = Console.ReadLine();
                    Goal goal = null;
                    switch (type)
                    {
                        case "1":
                            goal = new SimpleGoal { Name = name, Points = 1000};
                            Console.WriteLine("How many points is this activity worth?");
                            break;
                        case "2":
                            goal = new EternalGoal { Name = name, Points = 100 };
                            break;
                        case "3":
                            goal = new ChecklistGoal { Name = name, TimesToComplete = 10 };
                            break;
                    }
                    if (goal != null)
                    {
                        user.AddGoal(goal);
                    }
                    break;
                case "2":
                    user.DisplayGoals();
                    break;
                case "3":
                    user.SaveGoals("goals.txt");
                    break;
                case "4":
                    user.LoadGoals("goals.txt");
                    break;
                case "5":
                    Console.WriteLine("Enter goal name:");
                    var goalName = Console.ReadLine();
                    var goalToRecord = user.Goals.FirstOrDefault(g => g.Name == goalName);
                    if (goalToRecord != null)
                    {
                        user.RecordGoalProgress(goalToRecord);
                    }
                    break;
                case "6":
                    return;
            }
        }
    }
}
