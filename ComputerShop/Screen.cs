using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerShop
{
    class Screen : AddonDecorator
    {
        public Screen(IComputer c):base(c)
        {
        }

        public override double getPrice()
        {
            return 150 + base.getPrice();
        }

        public override string getDescription()
        {
            return base.getDescription() + "\nwith a screen of size " + getScreenSize() + " inches";
        }

        public double getScreenSize()
        {
            return 22;
        }
    }
}
