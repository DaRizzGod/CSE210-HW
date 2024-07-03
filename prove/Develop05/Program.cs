using System;

public class Program
{
    static void Main(string[] args)
    {
      GoalDashboard goalDashboard = new GoalDashboard();
      string input;
      while (true)
      {
        Console.WriteLine("1. Add Simple Goal");
        Console.WriteLine("2. Add Eternal Goal");
        Console.WriteLine("3. Add Checklist Goal");
        Console.WriteLine("4. Record Event");
        Console.WriteLine("5. Display Goals");
        Console.WriteLine("6. Display Points");
        Console.WriteLine("7. Save Goals");
        Console.WriteLine("8. Load Goals");
        Console.WriteLine("9. Exit");
        Console.Write("Select an option: ");
        input = Console.ReadLine();
        switch (input)
        {
            case "1":
                AddSimpleGoal(goalDashboard);
                break;
            case "2":
                AddEternalGoal(goalDashboard);
                break;
            case "3":
                AddChecklistGoal(goalDashboard);
                break;
                case "4":
            RecordEvent(goalDashboard);
                break;
            case "5":
                goalDashboard.DisplayGoals();
                break;
            case "6":
                Console.WriteLine($"Total Points: {goalDashboard.GetPoints()}");
                break;
            case "7":
                goalDashboard.SaveGoals();
                Console.WriteLine("Goals saved.");
                break;
            case "8":
                goalDashboard.LoadGoals();
                Console.WriteLine("Goals loaded.");
                break;
            case "9":
                return;
            default:
                Console.WriteLine("Invalid option, please try again.");
                break;

        }
      }
    }
      private static void AddSimpleGoal(GoalDashboard dashboard)
    {
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());
        SimpleGoal goal = new SimpleGoal(description, points);
        dashboard.AddGoal(goal);
    }

    private static void AddEternalGoal(GoalDashboard dashboard)
    {
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points per event: ");
        int points = int.Parse(Console.ReadLine());
        EternalGoal goal = new EternalGoal(description, points);
        dashboard.AddGoal(goal);
    }

    private static void AddChecklistGoal(GoalDashboard dashboard)
    {
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points per event: ");
        int pointsPerEvent = int.Parse(Console.ReadLine());
        Console.Write("Enter target count: ");
        int targetCount = int.Parse(Console.ReadLine());
        Console.Write("Enter bonus points: ");
        int bonusPoints = int.Parse(Console.ReadLine());
        ChecklistGoal goal = new ChecklistGoal(description, pointsPerEvent, targetCount, bonusPoints);
        dashboard.AddGoal(goal);
    }

    private static void RecordEvent(GoalDashboard dashboard)
    {
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        dashboard.RecordEvent(description);
    }
}