using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class CarWithConditioner : DecoratedCar
    {
        private int componentPrice;
        public CarWithConditioner(ICar carToBeDecorated, int componentPrice)
            :base(carToBeDecorated)
        {
            this.componentPrice = componentPrice;
        }
        public override string GetDescription()
        {
            return base.GetDescription() + " with conditioner.";
        }
        public override int GetPrice()
        {
            return base.GetPrice() + componentPrice;
        }
    }
}
