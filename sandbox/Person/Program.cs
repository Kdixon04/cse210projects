class Program
{
    public static void Main()
    {
        Person myperson = new Person("John", "Revelator", 2050, 180);
        Console.WriteLine(myperson.GetPersonInfo());

        Doctor myDoctor = new Doctor ("Bob", "Payne", 45, 279, "Scalpal");
        Console.WriteLine(myDoctor.GetPersonInfo());
        Console.WriteLine(myDoctor.GetDoctorInfo());

        Police myPolice = new Police("Gary", "Goodman", 61, 181, "Guns");
        Console.WriteLine(myPolice.GetPoliceInfo());
        
    }
}
