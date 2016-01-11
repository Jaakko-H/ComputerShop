using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerShop
{
    class TablePC : IComputer
    {
        public string getDescription()
        {
            return "Just a table pc.";
        }

        public double getPrice()
        {
            return 400;
        }
    }
}
