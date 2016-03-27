using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class HolidayTaxVisitor : IVisitor
    {

        public double visit(Tobacco tobaco)
        {
            return tobaco.getPrice() * 1.05;
        }

        public double visit(Liquor liquor)
        {
            return liquor.getPrice() * 1.1;
        }
    }
}
