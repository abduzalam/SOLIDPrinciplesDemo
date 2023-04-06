using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// In this class we can use Factory to create Logger and Emailer to create the new Objects
// But that will create a dependency which we can avoid by using initialization through constructor

// The reason we are not using the Factory.CreateEmailer or CreatedLogger because I want the high level to give what I want , not ask for it

// Here the idea is except the factory class, there is no newing up the class objects in other places
// see this code file 
namespace DemoClassLibrary
{
    public class Chore : IChore
    {
        ILogger _logger;
        IMessageSender _messageSender;
        public string? ChoreName { get; set; }
        public IPerson? Owner { get; set; }

        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }


        public Chore(ILogger logger, IMessageSender messageSender)
        {
            _logger = logger;
            _messageSender = messageSender;
        }
        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            _logger.Log($"Performed work on {ChoreName}");
        }

        public void CompleteChore()
        {
            IsComplete = true;

            _logger.Log($"Completed {ChoreName}");

            _messageSender.SendMessage(Owner, $"The Chore {ChoreName} is complete");
        }
    }


}
