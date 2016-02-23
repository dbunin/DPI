using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1
{
    class RemoveNormal : IRemove
    {
        //returns 0 if it's not ment to be removed, 1 if it reached next number
        public int Remove(List<int> l, int toCheck, int nextNumber)
        {
            if (toCheck == nextNumber)
                return 1;
            return 0;
        }
    }
}
