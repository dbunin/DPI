using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1
{
    class ShortestSeekTime : IAlgorithm
    {
        IFindNext findNext = new FindNextSST();
        IRemove remove = new RemoveNormal();
        //returns next number from the given list. Current number is the previous number. IF there are number after previous number, it will return this int, if not it will return -1.
        public int FindNext(List<int> l, int currentNumber)
        {
            return ((FindNextSST)findNext).GetNext(l, currentNumber);
        }
        public int Remove(List<int> l, int checkIfRemove, int nextNumber)
        {
            return ((RemoveNormal)remove).Remove(l, checkIfRemove, nextNumber);
        }
    }
}
