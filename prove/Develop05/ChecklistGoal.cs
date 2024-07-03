using System.Text.Json;

public class ChecklistGoal : Goal
{
    private int _pointsPerEvent {get; set;}
    private int _bonusPoints {get; set;}
    private int _targetCount {get; set;}
    private int _currentCount {get; set;}

    public ChecklistGoal() { }

    public ChecklistGoal(string description, int pointsPerEvent, int targetCount, int bonusPoints)
    {
        Description = description;
        _pointsPerEvent = pointsPerEvent;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
        IsCompleted = false;
    }

    public override int RecordEvent()
    {
        if (!IsCompleted)
        {
            _currentCount++;
            if (_currentCount >= _targetCount)
            {
                IsCompleted = true;
                return _pointsPerEvent + _bonusPoints;
            }
            return _pointsPerEvent;
        }
        return 0;
    }

    public override string Display()
    {
        return $"[ChecklistGoal] {Description} - Completed: {IsCompleted}, Progress: {_currentCount}/{_targetCount}, Points per event: {_pointsPerEvent}, Bonus Points: {_bonusPoints}";
    }
}