using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPEx2Initial
{
    public class MonitorFilter
    {
        /// <summary>
        /// This is our first requirement,  Only filter the monitors by monitor type
        /// </summary>
        /// <param name="monitors"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<ComputerMonitor> FilterByMonitorType(IEnumerable<ComputerMonitor> monitors, MonitorType type) => monitors.Where(m => m.MonitorType == type).ToList();
        /// <summary>
        /// This method we added a later point in time when the new requirement came to filter the monitors by Screen type
        /// The direct modification of existing working class in production violates our OCP here , but we have no choice at this time, so we are modifying it
        /// </summary>
        /// <param name="monitors"></param>
        /// <param name="screentype"></param>
        /// <returns></returns>
        public List<ComputerMonitor> FilterByScreen(IEnumerable<ComputerMonitor> monitors, Screen screentype) => monitors.Where(m=> m.Screen == screentype).ToList();
    }
}
