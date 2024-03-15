public abstract class Goal
{
    private string _name;
    private int _points;
    private bool _isComplete;

    public string Name { get => _name; set => _name = value; }
    public int Points { get => _points; set => _points = value; }
    public bool IsComplete { get => _isComplete; set => _isComplete = value; }

    public abstract void RecordProgress();
}