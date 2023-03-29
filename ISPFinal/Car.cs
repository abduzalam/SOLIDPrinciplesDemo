using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPFinal
{
    public class Car : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Drive a car, this is from Car class");
        }
    }
}
