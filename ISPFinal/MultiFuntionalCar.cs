using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPFinal
{
    public class MultiFuntionalCar : ICar, IAirplane
    {
        public void Drive()
        {
            Console.WriteLine("Drive a multifunctional car");
        }

        public void Fly()
        {
            Console.WriteLine("Fly a multifunctional car");
        }
    }
}
