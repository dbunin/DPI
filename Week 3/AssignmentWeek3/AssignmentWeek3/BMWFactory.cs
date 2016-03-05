using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentWeek3
{
    class BMWFactory : IFactory
    {
        IBrand brand;
        List<IType> typesCreated;
        public BMWFactory()
        {
            brand = new BMW();
            typesCreated = new List<IType>();
        }
        public string CreateCarTypeSport()
        {
            IType type = new Sport();
            typesCreated.Add(type);
            string temp = brand.ReturnBrand() + " of type " + type.ReturnType() + " is created.";
            return temp;
        }
        public string CreateCarTypeEconom()
        {
            IType type = new Econom();
            typesCreated.Add(type);
            string temp = brand.ReturnBrand() + " of type " + type.ReturnType() + " is created.";
            return temp;
        }
        public List<String> GetCarsCreated()
        {
            List<String> cars = new List<string>();
            foreach(IType type in typesCreated)
            {
                cars.Add(brand.ReturnBrand() + " of type " + type.ReturnType());
            }
            return cars;
        }
    }
}
