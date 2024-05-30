using System;


class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Egnineer";
        job1._company = "Nvaida";
        job1._startYear = 2000;
        job1._endYear = 2012;

        Job job2 = new Job();
        job2._jobTitle = "Chief Financial Officer";
        job2._company = "rawlings";
        job2._startYear = 2014;
        job2._endYear = 2020;

        Resume myResume = new Resume();
        myResume._name = "Miles Josephson";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}