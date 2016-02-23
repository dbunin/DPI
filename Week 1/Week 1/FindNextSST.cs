using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1
{
    class FindNextSST : IFindNext
    {
        //returns next item from the list l
        public int GetNext(List<int> l, int currentNumber)
        {
            int seekedNumber = -1;
            int subtraction = 100; //100 is the biggest number in the array, so the substraction will always be smaller then 100
            foreach (int i in l)
            {
                if (subtraction > Math.Abs(currentNumber - i) && currentNumber - i != 0)
                {
                    subtraction = Math.Abs(currentNumber - i);
                    seekedNumber = i;
                }
            }
            return seekedNumber;
        }
    }
}
