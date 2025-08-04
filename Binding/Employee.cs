using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Binding
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }



        public virtual void Function01()
        {
            Console.WriteLine("Employee Class");
        }

        public virtual void Function02()
        {
            Console.WriteLine($"Id: {Id}, \nName: {Name}, \nAge: {Age}");
        }
    }
}
