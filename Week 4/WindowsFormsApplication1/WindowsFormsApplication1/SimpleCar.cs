using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class SimpleCar : ICar
    {
        private int price;
        private string description;

        public SimpleCar(int price)
        {
            this.price = price;
            this.description = "Simple car";
        }

        public int GetPrice()
        {
            return price;
        }
        public string GetDescription()
        {
            return description;
        }
    }
}
