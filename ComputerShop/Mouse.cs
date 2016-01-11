using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerShop
{
    class Mouse : AddonDecorator
    {
        public Mouse(IComputer c) : base(c)
        {
        }

        public override double getPrice()
        {
            return 20 + base.getPrice();
        }

        public override string getDescription()
        {
            return base.getDescription() + "\nwith a " + getMouseType() + " mouse";
        }

        public string getMouseType()
        {
            return "wired";
        }
    }
}
