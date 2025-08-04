using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExampleOneInterface
{
    internal class SeriesOne : ISeries
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current+= 2;
        }
    }
}
