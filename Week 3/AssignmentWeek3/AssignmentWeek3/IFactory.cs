using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentWeek3
{
    public interface IFactory
    {
        string CreateCarTypeSport();
        string CreateCarTypeEconom();
        List<String> GetCarsCreated();
    }
}
