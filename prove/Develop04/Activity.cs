using System.Diagnostics.Metrics;

abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public virtual void Run()
    {
        Console.Clear();
        Console.WriteLine($"Activity: {_name}");
        Console.WriteLine(_description);
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin. . .");
        DisplaySpinner(3);
    }
    
    protected void DisplaySpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("/b-");
            Thread.Sleep(250);
            Console.Write("/b//");
            Thread.Sleep(250);
            Console.Write("/b|");
            Thread.Sleep(250);
            Console.Write("/b");

        }
    }

    protected void End()
    {
        Console.WriteLine("Good job! You've completed the activity. ");
        DisplaySpinner(3);
        Console.WriteLine($"Activity: {_name}, Duration: {_duration} sounds");
        DisplaySpinner(3);
    }
}
 