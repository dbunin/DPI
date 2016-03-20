using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
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
        public List<String> GetState()
        {
            List<String> temp = new List<string>();
            temp.Add("The TV is " + state);
            temp.Add("The volume is " + volume);
            return temp;
        }
    }
}
