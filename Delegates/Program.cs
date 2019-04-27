using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Program
    {
        private static List<Employee> Employees = new List<Employee>();

        private delegate void PrintEmployeeProcessor(Employee employee);

        private static void PrintEmployee(Employee employee)
        {
            Console.WriteLine(employee.ToString());
        }
        private static void InitSalary(Employee employee)
        {
            employee.Salary = 0;
        }

        private static void ProcessEmployees(PrintEmployeeProcessor processor)
        {
            foreach (Employee employee in Employees)
            {
                processor(employee);
            }
        }

        private static void GenerateEmployees()
        {
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                Employees.Add(new Employee()
                {
                    Name = Guid.NewGuid().ToString(),
                    Title = Guid.NewGuid().ToString(),
                    Salary = (decimal)random.NextDouble()
                });
            }
        }

        static void Main(string[] args)
        {
            GenerateEmployees();
            ProcessEmployees(PrintEmployee);
            ProcessEmployees(InitSalary);

            ProcessEmployees(PrintEmployee);
        }


    }
}
