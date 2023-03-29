using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPFinal
{
    /// <summary>
    /// Assume if we have already implemented the Drive and Fly methods in Car and Airplane class respectively
    /// In this case, instead of implementing the feaure again, we can make a call to the car class in this way
    /// expalined in this example class
    /// </summary>
    public class MultiFunctionalCarRev2 : IMultiFuctionalCar
    {
        public ICar _car { get; private set; } // This _car is visible from MultiFunctionalCarRev2 class object, but can't set the value due to private set

        public IAirplane _airplane { get; private set; }

        private readonly ICar _car1; // This _car1 can also set from constructor, the difference is this method does not visible to MultiFunctionalCarRev2 class object

        public MultiFunctionalCarRev2(ICar car, IAirplane airplane)
        {
            _car = car;
            _airplane = airplane;
            _car1 = car;
        }

        // This type of implementation is an example of Decorator pattern
        public void Drive()
        {
            _car.Drive();
        }

        public void Fly()
        {
            _airplane.Fly();
        }
    }
}
