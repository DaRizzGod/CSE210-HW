using System.Reflection;

public class Mindfulness
{
  protected string _endmessage = "";
  protected string _animation ="";

  public Mindfulness(string endmessage,string animation)
    
  {
    _endmessage = endmessage;
    _animation = animation;
  }

  public string GetResult()
  {
    return $"Here is your result: {_endmessage}";
  }

  public string GetFrames()
  {
        return $"{_animation}";
  }
  
}