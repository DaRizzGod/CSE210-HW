using System.Runtime.InteropServices;

public class Breathing
{
    protected string _description = "";
    protected string _reflection = "";
    protected string _prompts = "";
    protected string _subtitle = "";

    public Breathing(string description, string reflection, string prompts, string subtitle)
        
    {
        _description = description;
        _reflection = reflection;
        _prompts = prompts;
        _subtitle = subtitle;
    }

    public string GetBreathingInfo()
    {
        string info = "";
        info += "Description: " +_description + "/n";
        info += "Reflection: " + _reflection + "/n";
        info += "Prompts: " + _prompts + "/n";
        info += "Subtitle: " + _subtitle;
        return info;
    }

}




