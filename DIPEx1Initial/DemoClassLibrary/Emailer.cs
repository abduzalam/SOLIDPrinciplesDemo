using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClassLibrary
{
    public class Emailer
    {
        public void SendEmail(Person owner, string message)
        {
            Console.WriteLine($"Simulating sending an email to { owner.EmailAddress }");
        }
    }
}
