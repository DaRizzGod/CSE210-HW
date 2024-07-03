using System.Text.Json;

public class EternalGoal : Goal
{
    private int Points { get; set; }

    public EternalGoal() { }
    public EternalGoal(string description, int points)
    {
        Description = description;
        Points = points;
        IsCompleted = false;
    }

    public override int RecordEvent()
    {
        return Points;
    }

    public override string Display()
    {
        return $"[EternalGoal] {Description} - Points per event: {Points}";
    }
}