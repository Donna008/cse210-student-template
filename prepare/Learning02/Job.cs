using System.Security.Cryptography.X509Certificates;

public class Job{
    // for underscore's value name is a memeber name.
    public string _company;
    //  for public we also can use private, and if we use it we don't need to in valuable name add a underscore.
    // eg. private int stratYear
    public string _jobTitle;

    public int _startYear;

    public int endYear;

    public void Dispaly(){
        Console.WriteLine($"{_jobTitle} {_company} {_startYear} {endYear}");

    }
}