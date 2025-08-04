using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Binding
{
    internal class PartNameEmp : Employee
    {
        public decimal HourlyRate { get; set; }
        public int HoursWorked { get; set; }




        public new virtual void Function01()
        {
            Console.WriteLine("Hello Part Time Employee ");
        }
        public override void Function02()
        {
            Console.WriteLine($"Id: {Id}, \nName: {Name}, \nAge: {Age}, \nHourly Rate: {HourlyRate}, \nHours Worked: {HoursWorked}");
        }
    }
}
