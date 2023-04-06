using ConsoleUI;
using DemoClassLibrary;

internal class Program
{
    /// <summary>
    /// This Application Totally violates DI
    /// DI States that HighLevel Modules should not depend on low level modules, rather both should depends on Abstractions
    /// and those Abstactions should not depends on details
    /// 
    /// DI Says we have to invert the dependency , So low level module depends on high level . meaning both should depend on abstraction
    /// and those abstractions should not depend on details, meaning those abstractions shouldn't have to know about how things are getting done
    /// it should just say these are things that will get done

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
    // and those abstractions should not depend on details, meaning those abstractions shouldn't have to know about how things are getting done
    // it should just say these are things that will get done

    // There are couple of ways to do Abstractions, the simplest way is to use Interfaces

    // iN THIS CODE     , WE  newly creating objects only in Factory, and it is asking for the objects only in the program.cs
    // this code disconnects from everything, so if we change anything in the low level module, nothing will break
    //even if we replace the Person class with a Student class, no issue, if the contract is same 

    //  we can easily replace a Emailer class with a Texter class to send a text message instead of Email , so the code is completely independent here


    private static void Main(string[] args)
    {
        Console.WriteLine("DIPEx1 Final Project!");
        Console.WriteLine();

        IPerson owner = Factory.CreatePerson();
        owner.FirtName = "Abdul";
        owner.LastName = "Kuzhiyil";
        owner.EmailAddress = "abdul@abdul.com";
        owner.PhoneNumber = "555-1212";

        IChore chore = Factory.CreateChore();

        chore.ChoreName = "Take out the trash";
        chore.Owner = owner;


        chore.PerformedWork(3);
        chore.PerformedWork(1.5);
        chore.CompleteChore();
        Console.ReadLine();
    }
}