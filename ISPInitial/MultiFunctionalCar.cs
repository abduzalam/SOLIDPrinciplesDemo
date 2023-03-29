using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPInitial
{
    public class MultiFunctionalCar : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Drive a multifunctional car!");
        }

        public void Fly()
        {
            Console.WriteLine("Fly a multifunctional car!");
        }
    }
}

// This works fine

// but now we want to implement a Car class and Airplane class as well, see the different Car and Airplane classes