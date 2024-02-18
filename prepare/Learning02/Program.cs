using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // for this code we also can short it to one line
        // eg.Job job1 = new Job();
        Job job1 = new Job();

        job1._company = "Del Taco";
        job1._jobTitle =" A name";
        job1._startYear = 1706;
        job1.endYear = 2020;
        job1.Dispaly();
        // Console.WriteLine("Hello Learning02 World!");
        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle =" A name1";
        job2._startYear = 2020;
        job2.endYear = 2024;
        job2.Dispaly();

        Resume r = new Resume();
        r._name = "Christopher";
        r._jobs.Add(job1);
        r._jobs.Add(job2);
        r.Dispaly();

    }
}