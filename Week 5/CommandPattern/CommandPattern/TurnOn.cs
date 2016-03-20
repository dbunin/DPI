using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class TurnOn : Command
    {
        ElectronicDevice newDevice;
        public TurnOn(ElectronicDevice newDevice)
        {
            this.newDevice = newDevice;
        }
        public List<string> execute()
        {
            List<String> temp = new List<string>();
            temp.Add(newDevice.On());
            return temp;
        }

        public string undo()
        {
            return newDevice.Off();
        }
    }
}
