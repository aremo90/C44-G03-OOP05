using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1.Question_04
{
    internal class GuestUser : User
    {
        public GuestUser(string name)
        {
            Name = name;
        }

        public override Discount GetDiscount()
        {
            return new NoDiscount();
        }
    }
}
