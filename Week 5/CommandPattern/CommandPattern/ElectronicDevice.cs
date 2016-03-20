using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    interface ElectronicDevice
    {
        string On();
        string Off();
        string VolumeUp();
        string VolumeDown();
        List<String> GetState();
    }
}
