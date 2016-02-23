using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1
{
    //returns next number from the given list. Current number is the previous number. IF there are number after previous number, it will return this int, if not it will return -1.
    interface IAlgorithm
    {
        int FindNext(List<int> l, int currentNumber);
        int Remove(List<int> l, int checkIfRemove, int nextNumber);
    }
}
