using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Device
{
    interface ElectronicDevice
    {
        string On();
        string Off();
        string VolumeUp();
        string VolumeDown();
    }
}
