using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class DecoratedCar : ICar
    {
        protected ICar carToBeDecorated;
        protected string description;
        public DecoratedCar(ICar carToBeDecorated)
        {
            this.carToBeDecorated = carToBeDecorated;
            description = "Decorated car";
        }
        public virtual string GetDescription()
        {
            return description;
        }
        public virtual int GetPrice()
        {
            return carToBeDecorated.GetPrice();
        }
    }
}
