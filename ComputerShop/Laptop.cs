using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerShop
{
    class Laptop : IComputer
    {
        public string getDescription()
        {
            return "A good laptop computer";
        }

        public double getPrice()
        {
            return 500;
        }
    }
}
