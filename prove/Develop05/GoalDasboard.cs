using System.Runtime.CompilerServices;
using System.Text.Json;

public class GoalDashboard
{
  private List<Goal> _goals;
  private int _totalPoints;

  public GoalDashboard()
  {
    _goals = new List<Goal>();
    _totalPoints = 0;
  }

  public void AddGoal(Goal goal)
  {
    _goals.Add(goal);
  }

  public void DisplayGoals()
  {
    Console.WriteLine("Goals:");
    foreach (var goal in _goals)
    {
      Console.WriteLine(goal.Display());
    }
  }

  public void RecordEvent(string description)
  {
    foreach (var goal in _goals)
    {
      if (goal.Description == description)
      {
        _totalPoints += goal.RecordEvent();
        break;
      }
    }
  }

  public int GetPoints()
  {
    return _totalPoints;
  }

  public void SaveGoals()
  {
    var options = new JsonSerializerOptions { WriteIndented = true, Converters = { new GoalConverter() } };
    string json = JsonSerializer.Serialize(_goals, new JsonSerializerOptions { WriteIndented = true});
    File.WriteAllText("goals.json", json);
  }

  public void LoadGoals()
  {
    if (File.Exists("goals.json"))
    {
      string json = (File.ReadAllText("goals.json"));
      var options = new JsonSerializerOptions { Converters = {new GoalConverter() } };
      _goals = JsonSerializer.Deserialize<List<Goal>>(json, options);
    }
  }
}
