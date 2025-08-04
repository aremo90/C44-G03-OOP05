using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Binding
{
    internal class FullTimeEmp : Employee
    {
        public decimal salary { get; set; }


        public override void Function01()
        {
            Console.WriteLine("Hello Full Time Employee ");
        }
        public override void Function02()
        {
            Console.WriteLine($"Id: {Id}, \nName: {Name}, \nAge: {Age}, \nSalary: {salary}");
        }
    }
}
