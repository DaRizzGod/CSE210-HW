using System;

public class Program 
{
    static void Main(string[] args)
    {

        Listing Listing = new Listing("Enter your prompt here", "Tell how you are feeling", 30);
        Console.WriteLine(Listing.GetListingInfo());

        Breathing breathing = new Breathing("Enter your description here","Enter your reflection here", "Enter your prompts here", "Enter your subtitle here");
        Console.WriteLine(breathing.GetBreathingInfo());

        Timer timer = new Timer("Enter your timer setting here");
        Console.WriteLine(timer.GetTimerInfo());

        Mindfulness mindfulness = new Mindfulness("Enter your end messgae here","Enter your animation frames here");
        Console.WriteLine(mindfulness.GetResult());
    }
}