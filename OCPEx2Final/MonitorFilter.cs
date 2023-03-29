using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPEx2Final
{
    public class MonitorFilter : IFilter<ComputerMonitor>
    {
        
        public List<ComputerMonitor> Filter(IEnumerable<ComputerMonitor> monitors, ISpecification<ComputerMonitor> specification)
        {
            return monitors.Where(m=> specification.isSatisfied(m)).ToList();
        }
    }
}
