using DemoClassLibrary;

internal class Program
{
    /// <summary>
    /// This Application Totally violates DI
    /// DI States that HighLevel Modules should not depend on low level modules, rather both should depends on Abstractions
    /// and those Abstactions should not depends on details
    /// </summary>
    /// <param name="args"></param>
    
    // In this Example , a high level module means anything its call something else
    // Here Static void main call to Person class, Chore Class. So Main depends on Person and Chore class. Main is in this case is a high level module

    // Chore class is also a high level module , because it depends on the Logger and Emailer class

    // Emailer class is not depend on nothing - This is a low level module
    // Logger class also not depend on nothing - So this is a low level module
    
    // So the Program class and Chore class those are high level module which depends on low level module classes
    // So what this means is if I change Logger class or Emailer class, the Chore class will break, which breaks the program.cs class

    // DI Says we have to invert the dependency , So low level module depends on high level . meaning both should depend on abstraction

    // There are couple of ways to do Abstractions, the simplest way is to use Interfaces

    // Now look at the DIPEx1Final Project , which shows this code is converted in to DIP 
    private static void Main(string[] args)
    {
        Console.WriteLine("DIPEx1 Initial Project!");
        Console.WriteLine();

        Person owner = new Person
        {
            FirtName = "Abdul",
            LastName = "Kuzhiyil",
            EmailAddress = "abdul@abdul.com",
            PhoneNumber = "555-1212"
        };

        Chore chore = new Chore()
        {
            ChoreName = "Take out the trash",
            Owner = owner,
        };

        chore.PerformedWork(3);
        chore.PerformedWork(1.5);
        chore.CompleteChore();
        Console.ReadLine();
    }
}