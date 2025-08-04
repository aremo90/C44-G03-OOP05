using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExampleTwoInterface
{
    internal interface IMoveOnGround
    {
        public void forward();
        public void backward();
        public void turnLeft();
        public void turnRight();

    }
}
