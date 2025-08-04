using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Abstraction
{
    internal class Square : BaseArea
    {
        public Square(decimal Dim) 
        {
            Dim01 = Dim02 = Dim;
        }

        public override decimal Perimeter =>  Dim01 * 4;
    }
}
