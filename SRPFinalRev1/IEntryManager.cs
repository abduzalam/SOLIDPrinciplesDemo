using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPFinalRev1
{
    public interface IEntryManager<T>
    {
        void AddEntry(T entry);
        void RemoveEntryAt(int index);
    }
}
