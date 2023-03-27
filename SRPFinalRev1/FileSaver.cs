using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPFinalRev1
{
    // public class FileSaver<T> : If we create a class like this, we need to create two Objects for FileSaver class to call savetofile method
    // So we declare our savetofile method as SaveToFile<T>, so we can call savetofile method using a single object of FileSaver class
    public class FileSaver
    {
        public void SaveToFile<T>(string directoryName, string fileName, IEntryManager<T> workReport)
        {
            if (Directory.Exists(directoryName) == false)
            {
                Directory.CreateDirectory(directoryName);
            }
            File.WriteAllText(Path.Combine(directoryName, fileName), ToString());
        }
    }
}
