using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPFinal
{
    //We can do this as well by combining required Interfaces into one and used as an example in this class
    public class MultiFunctionalCarRev1 : IMultiFuctionalCar
    {
        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
}
