﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class TVRemote : Remote
    {
        public ElectronicDevice GetDevice()
        {
            return new Television();
        }
    }
}
