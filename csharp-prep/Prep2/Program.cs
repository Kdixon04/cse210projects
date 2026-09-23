using System;

class Program
{
 static void Main(string[] args)
    {
    string grade;
    Console.WriteLine("What grade percentage did you get?");    
    grade = Console.ReadLine();
    int gradeNumber = int.Parse(grade);
    string finalScore;
    string passFail;


    if (gradeNumber >= 90)
        {
         finalScore = "A";
         passFail = "Pass";   
        }
    else if (gradeNumber >= 80)
        {
         finalScore = "B";
         passFail = "Pass";
        }
    else if (gradeNumber >= 70)
        {
         finalScore = "C";
         passFail = "Pass";
        }
    else if (gradeNumber >= 60)
        {
         finalScore = "D"; 
         passFail = "Fail";  
        }    
    else
        {
         finalScore = "F"; 
         passFail = "Fail";  
        }

    Console.WriteLine(finalScore);
    Console.WriteLine(passFail);            
    }
}