using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class VolumeDown : Command
    {
        ElectronicDevice newDevice;
        public VolumeDown(ElectronicDevice newDevice)
        {
            this.newDevice = newDevice;
        }
        public List<String> execute()
        {
            List<String> temp = new List<string>();
            temp.Add(newDevice.VolumeDown());
            return temp;
        }

        public string undo()
        {
            return newDevice.VolumeUp();
        }
    }
}
