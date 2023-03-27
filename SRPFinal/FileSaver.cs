using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPFinal
{
    public class FileSaver
    {
        public void SaveToFile(string directoryName, string fileName)
        {
            if (Directory.Exists(directoryName) == false)
            {
                Directory.CreateDirectory(directoryName);
            }
            File.WriteAllText(Path.Combine(directoryName, fileName), ToString());
        }
    }
}
