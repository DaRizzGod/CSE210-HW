using System.Runtime.InteropServices;
using System.Text.Json;

public class SimpleGoal : Goal
{
    private int Points {get; set; }
    public SimpleGoal() { }

    public SimpleGoal(string description, int points)
    {
        Description = description;
        Points = points;
        IsCompleted = false;
    }

    public override int RecordEvent()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
            return Points;
        }
        return 0;
    }

    public override string Display()
    {
        return $"[SimpleGoal] {Description} - Completed: {IsCompleted}, Points: {Points}";
    }
  
}