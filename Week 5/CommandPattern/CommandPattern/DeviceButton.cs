using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class DeviceButton
    {
        Command theCommand;
        
        public DeviceButton(Command newCommand)
        {
            theCommand = newCommand;
        }
        public List<String> press()
        {
            return theCommand.execute();
        }
        public string undo()
        {
             return theCommand.undo();
        }
    }
}
