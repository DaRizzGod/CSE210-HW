using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks.Dataflow;

class Job
{
    public string _jobTitle;
    public string _company;

    public void DisplayJobDetails()
    {
       Console.WriteLine("Job Title: " + _jobTitle); 
       Console.WriteLine("Company: " + _company);
    }
        
}

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._jobTitle = "Programmer";
        job1._company = "Apple";

        job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._jobTitle = "Gamer";
        job2._company = "Xbox";

       job2.DisplayJobDetails();
    }
}