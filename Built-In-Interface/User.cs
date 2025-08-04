using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Built_In_Interface
{
    internal class User : ICloneable , IComparable<User> 
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }


        public object Clone()
        {
            return new User
            {
                Id = this.Id,
                Name = this.Name,
                Salary = this.Salary
            };
        }

        public int CompareTo(User? other)
        {
            // Return 1 , -1 , 0
            // Salary > other.Salary => 1
            // Salary < other.Salary => -1
            // Salary == other.Salary => 0

            if (this.Salary > other?.Salary)
                return 1;
            else if (this.Salary < other?.Salary)
                return -1;
            else
                return 0;

        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary}";
        }
    }
}
