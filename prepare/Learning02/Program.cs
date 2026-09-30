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
        job1.DisplayJobDetails = $"{job1._jobTitle} ({job1._company}) {job1._startYear}-{job1._endYear}";

        Job job2 = new Job();

        job2._jobTitle = "Team Member";
        job2._company = "Chick Fil-A Crossroads";
        job2._startYear = 2025;
        job2._endYear = 2025;
        job2.DisplayJobDetails = $"{job2._jobTitle} ({job2._company}) {job2._startYear}-{job2._endYear}";


        Console.WriteLine(job1.DisplayJobDetails);
        Console.WriteLine(job2.DisplayJobDetails);

        Resume myResume = new Resume();

        myResume._personsName = "Keyan Dixon";
        myResume._jobsResume.Add(job1);
        Console.WriteLine(myResume._jobsResume[0]._jobTitle);
    }
}