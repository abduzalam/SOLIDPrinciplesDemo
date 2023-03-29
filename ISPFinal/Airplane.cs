using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPFinal
{
    public class Airplane : IAirplane
    {
        public void Fly()
        {
            Console.WriteLine("Fly an Airplane, this is from Airplane class");
        }
    }
}
