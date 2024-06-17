using System;

public class Listing
{
    protected string _prompt;
    protected string _feeling;
    protected int _duration;

    public Listing(string prompt, string feeling, int duration)
    {
        _prompt = prompt;
        _feeling = feeling;
        _duration = duration;
    }

    public string GetListingInfo()
    {
        return $"Prompt: {_prompt}/nFeeling: {_feeling}/nDuration: {_duration} minutes";
    }
}

public class Breathing
{
    protected string _description;
    protected string _reflection;
    protected string _prompts;
    protected string _subtitle;

    public Breathing(string description, string reflection, string prompts, string subtitle)
    {
        _description = description;
        _reflection = reflection;
        _prompts = prompts;
        _subtitle = subtitle;
    }

    public string GetBreathingInfo()
    {
        return $"Description: {_description}/nReflection: {_reflection}/nPrompts: {_prompts}/nSubtitle: {_subtitle}";
    }
}

public class Timer
{
    protected string _prompt;
    protected int _seconds;
    protected int _minutes;
    protected int _hour;

    public Timer(string prompt, int seconds = 600, int minutes = 60, int hour = 1)
    {
        _prompt = prompt;
        _seconds = seconds;
        _minutes = minutes;
        _hour = hour;
    }

    public string GetTimerInfo()
    {
        return $"Prompt: {_prompt}/nSeconds: {_seconds}/nMinutes: {_minutes}/nHour: {_hour}";
    }
}

public class Mindfulness
{
    protected string _endMessage;
    protected string _animation;

    public Mindfulness(string endMessage, string animation)
    {
        _endMessage = endMessage;
        _animation = animation;
    }

    public string GetResult()
    {
        return $"Here is your result: {_endMessage}";
    }

    public string GetFrames()
    {
        return _animation;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Listing listing = new Listing("Enter your prompt here", "Tell how you are feeling", 30);
        Console.WriteLine(listing.GetListingInfo());

        Breathing breathing = new Breathing("Enter your description here", "Enter your reflection here", "Enter your prompts here", "Enter your subtitle here");
        Console.WriteLine(breathing.GetBreathingInfo());

        Timer timer = new Timer("Enter your timer setting here");
        Console.WriteLine(timer.GetTimerInfo());

        Mindfulness mindfulness = new Mindfulness("Enter your end message here", "Enter your animation frames here");
        Console.WriteLine(mindfulness.GetResult());
        Console.WriteLine(mindfulness.GetFrames());
    }
}

