using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerShop
{
    class ExternalHD : AddonDecorator
    {
        public ExternalHD(IComputer c) : base(c)
        {
        }

        public override double getPrice()
        {
            return 100 + base.getPrice();
        }

        public override string getDescription()
        {
            return base.getDescription() + "\nwith an external harddrive of size " + getHDSize() + "GB";
        }

        public double getHDSize()
        {
            return 1000;
        }
    }
}