using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class VolumeUp : Command
    {
        ElectronicDevice newDevice;
        public VolumeUp(ElectronicDevice newDevice)
        {
            this.newDevice = newDevice;
        }
        public List<String> execute()
        {
            List<String> temp = new List<string>();
            temp.Add(newDevice.VolumeUp());
            return temp;
        }

        public string undo()
        {
            return newDevice.VolumeDown();
        }
    }
}
