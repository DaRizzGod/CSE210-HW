public class Timer
{
    protected string _prompt;
    protected int _seconds;
    protected int _minutes;
    protected int _hour;

    public Timer (string prompt, int seconds, int minutes, int hour)
    {
        _prompt = prompt;
        _seconds = seconds;
        _minutes = minutes;
        _hour = hour;
    }

    public string GetTimerInfo()
    {
        string info = "";
        info += "Prompt" + _prompt + "/n";
        info += "seconds" + _seconds + "/n";
        info += "Minutes" + _minutes + "/n";
        info += "Hour" + _hour + "/n";
        return info;
    }
}