using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPEx2Final
{
    /// <summary>
    /// We have this Specification Interface which can accept any Type( type here is a class/enum of either MonitorType or Screen
    /// </summary>
    /// <returns>
    /// True/False based on our criteria satisfied or not
    /// </returns>
    /// <typeparam name="T"></typeparam>
    public interface ISpecification<T>
    {
        bool isSatisfied(T item);
    }
}
