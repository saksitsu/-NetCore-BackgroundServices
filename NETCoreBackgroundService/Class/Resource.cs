using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCoreBackgroundService.Class
{
    public class Resource
    {
        public void WriteFile(string filename)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, true))
            {
                file.WriteLine(DateTime.Now.ToString());
            }
        }

        public void WriteFile(string filename,string msg)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, true))
            {
                file.WriteLine(msg);
            }
        }
    }
}
