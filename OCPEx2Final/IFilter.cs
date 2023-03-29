using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPEx2Final
{
    /// <summary>
    /// This Interface can accept our moniors
    /// </summary>
    /// <returns>
    /// returns list of monitors based on our specification
    /// </returns>
    /// <remarks>
    /// Specification here is based on Screen type or monitor type 
    /// </remarks>
    /// <typeparam name="T"></typeparam>
    public interface IFilter<T>
    {
        List<T> Filter(IEnumerable<T> monitors, ISpecification<T> specification);
    }
}
