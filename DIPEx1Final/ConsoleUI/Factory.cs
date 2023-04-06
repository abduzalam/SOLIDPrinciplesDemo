using DemoClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    // We can the application without breaking anything by changinging the CreateMessageSender with different object
    // This is called depending on the abstractions, not implementations

    // Benefits:
    // 1. Change application with one piece
    // 2. Application is not one big monolithic, it is a tiny components app, so we cn unplug and plug something new 
    // 3. Now we are setting up for dependency injection, which is the way of implemething this priciple. 
    //    Dependency injects remove the factory class to create the object in program.cs file

    public static class Factory
    {
        public static IPerson CreatePerson() => new Person();

        public static IChore CreateChore() => new Chore(CreateLogger(), CreateMessageSender());

        public static ILogger CreateLogger() => new Logger();

        //public static IMessageSender CreateMessageSender() => new Emailer();
        public static IMessageSender CreateMessageSender() => new Texter();
    }
}
