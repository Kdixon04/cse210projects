using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
            Circle myCircle = new Circle();

            myCircle._radius = 10;

            Circle myCircle2 = new Circle();

            double area = myCircle.GetArea();

            double area2 = myCircle2.GetArea();

            Console.WriteLine(area);

            Console.WriteLine(area2);
    }

    // REMEMBER, Functions should do one thing and one thing only
    // static double AddNumbers(double x, int y)
    // {
    //     return x + y;        
    // }

    // static string MyName()
    // {
    //     return "Bob";
    // }

    // // void tells the computer that the function doesn't return a value
    // static void DisplayGreeting(string name)
    // {
    //     Console.WriteLine($"Welcome {name}, it's nice to meet you");
    // }

    // static void Main(string[] args)
    // {
    //     string myName = MyName();
    //     DisplayGreeting(myName);
    //     double total = AddNumbers(12.234, 20);
    //     Console.WriteLine(total);

        // int x = 10;
        // int y = 30;
        // int z = 40;
        // if ((x == 10 || y == 30 ) && z == 30)
        //{
        //      Console.WriteLine("x is 10");
        //      Console.Writeline("y is fun");    
        //}
        // else if (x == 20)
    
   
   


   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   

   
         
   
}