using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExampleTwoInterface
{
    internal class Car : Vehicle , IMoveOnGround
    {

        public void backward()
        {
            Console.WriteLine("Car Moving Backward");  
        }

        public void forward()
        {
            Console.WriteLine("Car Moving Forward");
        }
        

        public void turnLeft()
        {
            Console.WriteLine("Car Moving Left");
        }

        public void turnRight()
        {
            Console.WriteLine("Car Moving Right");
        }
    }
}
