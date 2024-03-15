public class SimpleGoal : Goal
{
    public override void RecordProgress()
    {
        IsComplete = true;
    }
}