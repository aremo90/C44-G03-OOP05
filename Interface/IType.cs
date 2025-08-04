using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface
{
    // developer one
    internal interface IType
    {
        // 1. Signature for property
        public int MyProperty { get; set; }

        // 2. Signature for Method
        public void MyMethod();

        // 3. Default implemented Method
        public void print()
        {
            Console.WriteLine("Hello from Default Method");
        }
    }
}
