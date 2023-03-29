using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPEx2Final
{
    public class MonitorTypeSpecification : ISpecification<ComputerMonitor>
    {
        public MonitorType _type { get; private set; }
        public MonitorTypeSpecification(MonitorType type) { _type = type; }
        public bool isSatisfied(ComputerMonitor item) => item.MonitorType == _type;

    }
}
