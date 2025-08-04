using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Binding
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }

        public TypeB(int a, int b) : base(a)
        {
            B = b;
        }

        // Apply method overriding 'new' in function 01
        public new void Func01()
        {
            Console.WriteLine("Child Class");
        }

        // Apply method overriding 'override' in function 02
        //Method itself
        //      must be public
        //      must be virtual    
        public override void Func02()
        {
            Console.WriteLine($"TypeB: A = {A}, B = {B}");
        }

    }
}
