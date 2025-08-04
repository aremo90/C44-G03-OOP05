using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExampleOneInterface
{
    internal class SeriesTwo : ISeries
    {
        public int Current { 
            get;
            set; 
        }

        public void GetNext()
        {
            Current += 3;
        }
    }
}
