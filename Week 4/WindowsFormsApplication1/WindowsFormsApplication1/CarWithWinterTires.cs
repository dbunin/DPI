using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class CarWithWinterTires : DecoratedCar
    {
        private int tiresPrice;
        public CarWithWinterTires(ICar carToBeDecorated, int tiresPrice)
            :base(carToBeDecorated)
        {
            this.tiresPrice = tiresPrice;
        }
        public override string GetDescription()
        {
            return base.GetDescription() + " with winterTires";
        }
        public override int GetPrice()
        {
            return base.GetPrice() + tiresPrice;
        }

    }
}
