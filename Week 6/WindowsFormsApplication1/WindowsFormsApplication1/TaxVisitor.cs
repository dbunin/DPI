using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class TaxVisitor : IVisitor
    {
        public TaxVisitor()
        {

        }


        public double visit(Tobacco tobacco)
        {
            return tobacco.getPrice() * 1.18;
        }

        public double visit(Liquor liquour)
        {
            return liquour.getPrice() * 1.38;
        }
    }
}
