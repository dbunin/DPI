﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Liquor : IVisitable
    {
        private double price;

        public Liquor(double price)
        {
            this.price = price;
        }
        public double accept(IVisitor visitor)
        {
            return visitor.visit(this);
        }
        public double getPrice()
        {
            return price;
        }
    }
}
