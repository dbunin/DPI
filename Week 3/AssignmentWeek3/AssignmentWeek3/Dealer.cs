using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentWeek3
{
    public class Dealer
    {
        string name;
        IFactory factory;
        public Dealer(IFactory factory, string name)
        {
            this.name = name;
            this.factory = factory;
        }
        public List<String> GetAllCarsCreatedByFactory()
        {
            return factory.GetCarsCreated();
        }
        public string CreateCarOfTypeEconom()
        {
            return factory.CreateCarTypeEconom();
        }
        public string CreateCarOfTypeSport()
        {
            return factory.CreateCarTypeSport();
        }
        public string GetName()
        {
            return name;
        }
    }
}
