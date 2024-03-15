public class User
{
    private string _name;
    private int _score;
    private List<Goal> _goals;

    public string Name { get => _name; set => _name = value; }
    public int Score { get => _score; set => _score = value; }
    public List<Goal> Goals { get => _goals; set => _goals = value; }

    public User()
    {
        Goals = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }

    public void RecordGoalProgress(Goal goal)
    {
        goal.RecordProgress();
        Score += goal.Points;
    }

    public void DisplayGoals()
    {
        foreach (var goal in Goals)
        {
            Console.WriteLine($"{goal.Name}: {goal.Points} points, {(goal.IsComplete ? "[X]" : "[ ]")}");
        }
    }

    public void SaveGoals(string filePath)
    {
        File.WriteAllLines(filePath, Goals.Select(g => $"{g.Name},{g.Points},{g.IsComplete}"));
    }

    public void LoadGoals(string filePath)
    {
        var lines = File.ReadAllLines(filePath);
        foreach (var line in lines)
        {
            var parts = line.Split(',');
            var goal = new SimpleGoal { Name = parts[0], Points = int.Parse(parts[1]), IsComplete = bool.Parse(parts[2]) };
            Goals.Add(goal);
        }
    }
}