using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class GetStateAll : Command
    {
        List<ElectronicDevice> allDevices;
        public GetStateAll(List<ElectronicDevice> allDevices)
        {
            this.allDevices = allDevices;
        }
        public List<String> execute()
        {
            List<String> temp = new List<string>();
            foreach (ElectronicDevice d in allDevices)
            {
                List<string> tempString = d.GetState();
                foreach (string s in tempString)
                {
                    temp.Add(s);
                }
                temp.Add("");
            }
            return temp;
        }

        public string undo()
        {
            return "";
        }
    }
}
