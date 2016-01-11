using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerShop
{
    /// <summary>
    /// the abstract decorator class to be derived by the add-ons themselves
    /// </summary>
    abstract class AddonDecorator : IComputer
    {
        IComputer computer;
        
        public AddonDecorator(IComputer c)
        {
            computer = c;
        }

        public virtual string getDescription()
        {
            return computer.getDescription();
        }

        public virtual double getPrice()
        {
            return computer.getPrice();
        }
    }
}
