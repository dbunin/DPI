using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1
{
    class FindNextNormal : IFindNext
    {
        //returns next item from the list l
        public int GetNext(List<int> l, int currentNumber)
        {
            if (l.Count() > 1)
                return l[0];
            else
                return -1;
        }
    }
}
