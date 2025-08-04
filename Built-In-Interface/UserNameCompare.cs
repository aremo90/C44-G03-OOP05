using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Built_In_Interface
{
    internal class UserNameCompare : IComparer<User>
    {
        public int Compare(User? x, User? y)
        {
            //  X.Name > Y.Name => 1
            //  X.Name < Y.Name => -1
            //  X.Name == Y.Name => 0

            return string.Compare(x?.Name, y?.Name);
        }
    }
}
