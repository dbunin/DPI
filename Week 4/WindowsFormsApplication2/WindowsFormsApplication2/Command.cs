using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Command
{
    interface Command
    {
        string execute();
        string undo();
    }
}
