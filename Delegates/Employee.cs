using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Employee
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Title: {Title}, Salary: {Salary} ";
        }
    }
}
