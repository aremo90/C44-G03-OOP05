using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Question_04
{
    internal class NoDiscount : Discount
    {
        public NoDiscount()
        {
            Name = "No Discount";
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return 0;
        }
    }
}
