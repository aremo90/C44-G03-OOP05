using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Abstraction
{
    internal class Circle : Shape
    {
        public Circle(decimal R) 
        {
        Dim01 = Dim02  = R;
        }
        public override decimal Perimeter => 2 * 3.13m * Dim01;

        public override decimal CalcArea()
        {
            return 3.14M * Dim01 * Dim02;
        }

    }
}
