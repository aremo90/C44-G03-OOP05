using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Question_04
{
    internal class FlatDiscount : Discount
    {
        private decimal flatAmount;

        public FlatDiscount(decimal flatAmount)
        {
            this.flatAmount = flatAmount;
            Name = $"Flat Discount: {flatAmount:C}";
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return flatAmount * (quantity >= 1 ? 1 : 0);
        }
    }
}
