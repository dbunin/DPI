using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class TurnOff : Command
    {
        ElectronicDevice newDevice;
        public TurnOff(ElectronicDevice newDevice)
        {
            this.newDevice = newDevice;
        }
        public List<String> execute()
        {
            List<String> temp = new List<string>();
            temp.Add(newDevice.Off());
            return temp;
        }

        public string undo()
        {
            return newDevice.On();
        }
    }
}
