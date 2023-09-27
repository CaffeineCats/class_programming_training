using System;

class Program
{
    static void Main(string[] args)
    {
        Resume resume = new Resume();

        resume._jobs.Add(new Job());
        resume._jobs.Add(new Job());

        resume._name = "Allison Rose";
        resume._jobs[0]._company = "Microsoft";
        resume._jobs[0]._jobTitle = "Software Engineer";
        resume._jobs[0]._startYear = 2019;
        resume._jobs[0]._endYear = 2022;

        resume._jobs[1]._company = "Apple";
        resume._jobs[1]._jobTitle = "Manager";
        resume._jobs[1]._startYear = 2022;
        resume._jobs[1]._endYear = 2023;

        resume.DisplayResume();
    }

}