public abstract class Goal
{
  public string Description {get; set;}
  public bool IsCompleted  {get; set;}
  public abstract int RecordEvent();
  public abstract string Display();
}

