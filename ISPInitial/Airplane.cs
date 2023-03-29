using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPInitial
{
    public class Airplane : IVehicle
    {
        /// <summary>
        /// Can't drive an airplane, so leave it not implemented
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            Console.WriteLine("Flying a plane");
        }
    }
}

// The problem here is, we have unused methods in both Airplan and Car classes