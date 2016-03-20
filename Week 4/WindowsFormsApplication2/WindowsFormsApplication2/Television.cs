using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Device
{
    class Television : ElectronicDevice
    {
        private string state = "off";
        private int volume = 0;

        public string Off()
        {
            state = "off";
            return "The TV is now " + state;
        }

        public string On()
        {
            state = "on";
            return "The TV is now " + state;
        }

        public string VolumeDown()
        {
            volume--;
            return "The TV volume is now " + volume;
        }

        public string VolumeUp()
        {
            volume++;
            return "The TV volume is now " + volume;
        }
    }
}
