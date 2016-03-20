using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    interface Command
    {
        List<string> execute();
        string undo();
    }
}
