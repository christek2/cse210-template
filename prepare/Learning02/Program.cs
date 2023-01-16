using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._companyName = "Walmart";
        job1._startYear = 2010;
        job1._endYear = 2015;

        Job job2 = new Job();
        job2._jobTitle = "SoftWare Engineer";
        job2._companyName = "Sony";
        job2._startYear = 2015;
        job2._endYear = 2021;

        Resume resume1 = new Resume();
        resume1._userName = "Kimball Christensen";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();
    }
}