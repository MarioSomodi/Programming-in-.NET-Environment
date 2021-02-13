using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees;

namespace CI
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository eR = new EmployeeRepository();
            var employees = eR.GetEmployees();

            Console.WriteLine("Unos raspona godina radnika od kojih zelite prosjecnu placu.");

            Console.Write("Unesite prvi integer: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Unesite drugi integer: ");
            int B = Convert.ToInt32(Console.ReadLine());

            var employeeGroup = employees.GroupBy(x => x.employeeAge >= A && x.employeeAge <= B).Select(g => new { condition = g.Key, Avg = g.Average(e => e.employeeSalary) });
            foreach (var group in employeeGroup) 
            {
                if (group.condition) 
                {
                    Console.WriteLine("Prosjecna placa radnika u rasponu godina od {0}-{1} je {2}", A, B, group.Avg);
                }
            }

            var employeeGroupAge = employees.GroupBy(x => x.employeeAge / 10).Select(g => new { ageGroup = g.Key, Sum = g.Sum(e => e.employeeSalary) });
            foreach (var group in employeeGroupAge)
            {
                Console.WriteLine("{0} suma placa iznosi {1}", group.ageGroup, group.Sum);
            }
            Console.ReadKey();
        }   
    }
}
