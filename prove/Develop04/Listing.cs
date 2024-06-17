using System.Diagnostics.Metrics;

public class Listing
{
    protected string _prompt = "";
    protected string _description = "";
    protected int _counter = 30;

    public Listing (string prompt, string description, int counter)
        
    {
        _prompt = prompt;
        _description = description;
        _counter = counter;
    }

    public string GetListingInfo()
    {
        string info = "";
        info += "Prompt" + _prompt + "/n";
        info += "Description" + _description + "/n";
        info += "Counter: " + _counter;
        return info;

    }
}
 