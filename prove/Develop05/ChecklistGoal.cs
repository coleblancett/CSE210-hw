public class ChecklistGoal : Goal
{
    private int _timesToComplete;
    private int _timesCompleted;

    public int TimesToComplete { get => _timesToComplete; set => _timesToComplete = value; }
    public int TimesCompleted { get => _timesCompleted; set => _timesCompleted = value; }

    public override void RecordProgress()
    {
        TimesCompleted++;
        Points += 50;

        if (TimesCompleted >= TimesToComplete)
        {
            IsComplete = true;
            Points += 500;
        }
    }
}