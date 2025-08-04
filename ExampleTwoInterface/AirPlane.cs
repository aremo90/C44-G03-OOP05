using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExampleTwoInterface
{
    internal class AirPlane : Vehicle, IMoveOnGround, IMoveOnAir
    {
        public void backward()
        {
            Console.WriteLine("Airplane Moving Backward");
        }
        public void forward()
        {
            Console.WriteLine("Airplane Moving Forward");
        }
        public void turnLeft()
        {
            Console.WriteLine("Airplane Moving Left");
        }

        public void turnRight()
        {
            Console.WriteLine("Airplane Moving Rigt");
        }
    }
}
