using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerShop
{
    class Keyboard : AddonDecorator
    {
        public Keyboard(IComputer c) : base(c)
        {
        }

        public override double getPrice()
        {
            return 50 + base.getPrice();
        }

        public override string getDescription()
        {
            return base.getDescription() + "\nwith a " + getKbType() + " keyboard";
        }

        public string getKbType()
        {
            return "wireless";
        }
    }
}
