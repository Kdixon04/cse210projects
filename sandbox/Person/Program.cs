class Program
{
    public static void DisplayPersonInfo(Person person)
    {
    //     if(person is Doctor doctor)
    //         {
    //             Console.WriteLine(doctor.GetPersonInfo());
    //         }
    //         else if (person is Police police)
    //         {
    //             Console.WriteLine(police.GetPersonInfo());
    //         }
    //         // If person isn't doctor
    //         else
    //         {
                Console.WriteLine(person.GetPersonInfo());    
            // }
    }
    public static void Main()
    {
        Person myPerson = new Person("John", "Revelator", 2050, 180);
        // Console.WriteLine(myPerson.GetPersonInfo());

        Doctor myDoctor = new Doctor ("Bob", "Payne", 45, 279, "Scalpal");
        // Console.WriteLine(myDoctor.GetPersonInfo());
        // Console.WriteLine(myDoctor.GetDoctorInfo());

        Police myPolice = new Police("Gary", "Goodman", 61, 181, "Guns");
        // Console.WriteLine(myPolice.GetPoliceInfo());

        List<Person> myPeople = new List<Person>();

        myPeople.Add(myPerson);
        myPeople.Add(myDoctor);
        myPeople.Add(myPolice);
        
        foreach(Person person in myPeople)
        {
            // If person is Doctor (LowerCase doctor)
            // if(person is Doctor doctor)
            // {
            //     Console.WriteLine(doctor.GetDoctorInfo());
            // }
            // // If person isn't doctor
            // else
            // {
            //     Console.WriteLine(person.GetPersonInfo());    
            // }

            DisplayPersonInfo(person);            
        }
    }
}
