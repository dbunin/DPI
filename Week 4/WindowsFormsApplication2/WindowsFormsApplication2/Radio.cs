using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Device
{
    class Radio : ElectronicDevice
    {
        private string state = "off";
        private int volume = 0;

        public string Off()
        {
            state = "off";
            return "The Radio is now " + state;
        }

        public string On()
        {
            state = "on";
            return "The Radio is now " + state;
        }

        public string VolumeDown()
        {
            volume--;
            return "The Radio volume is now " + volume;
        }

        public string VolumeUp()
        {
            volume++;
            return "The Radio volume is now " + volume;
        }
    }
}
