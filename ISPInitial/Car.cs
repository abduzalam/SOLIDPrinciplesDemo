using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPInitial
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a car");
        }

        /// <summary>
        /// This is a normal class, its not multi functional, so we can't implement Fly method inside car class, so leave it NotImplemented
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
}

// The problem here is, we have unused methods in both Airplan and Car classes