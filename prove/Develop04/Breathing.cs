using System.ComponentModel;
using System.Runtime.InteropServices;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This actvitiy will help you breathe in and out of your mouth."){ }

    public override void Run()
    {
        base.Run();

        int halfDuration = _duration / 2;
        for (int i = 0; i < halfDuration; i++)
        {
            Console.WriteLine("Breathe in. . .");
            DisplaySpinner(5);
            Console.WriteLine("Breahte out. . .");
            DisplaySpinner(5);
        }

        End();
    }
  

}




