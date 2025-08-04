using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Question_04
{
    internal abstract class User
    {
        public string Name { get; set; }
        public abstract Discount GetDiscount();
    }
}
