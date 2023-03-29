using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPEx2Final
{
    public class ScreenTypeSpecification : ISpecification<ComputerMonitor>
    {
        public Screen _screen { get; private set; }
        public ScreenTypeSpecification(Screen screen) { _screen = screen; }
        public bool isSatisfied(ComputerMonitor item) => item.Screen == _screen;
        
    }
}
