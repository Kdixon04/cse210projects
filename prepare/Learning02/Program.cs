using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._jobTitle = "Applications Engineer Assitant";
        job1._company = "BYU-Idaho IT Department";
        job1._startYear = 2025;
        job1._endYear = 2028;

        Job job2 = new Job();

        job2._jobTitle = "Team Member";
        job2._company = "Chick Fil-A Crossroads";
        job2._startYear = 2025;
        job2._endYear = 2025;


        Console.WriteLine(job1);
        Console.WriteLine(job2);
    }
}