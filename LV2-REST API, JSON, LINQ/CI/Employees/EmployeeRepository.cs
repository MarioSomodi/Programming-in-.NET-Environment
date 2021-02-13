using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Employees
{
    public class EmployeeRepository
    {
        public List<Employee> GetEmployees() 
        {
            var json = CallRestMethod("http://dummy.restapiexample.com/api/v1/employees");
            JObject jsonObject = JObject.Parse(json);
            var jsonEmployees = jsonObject["data"].ToList();
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < jsonEmployees.Count(); i++) 
            {
                int id, employeeage, employeesalary;
                string employeename;
                if (String.IsNullOrWhiteSpace(Convert.ToString((int)jsonEmployees[i]["id"])))
                {
                    id = 0;
                }
                else
                {
                    id = (int)jsonEmployees[i]["id"];
                }
                if (String.IsNullOrWhiteSpace(Convert.ToString((int)jsonEmployees[i]["employee_age"])))
                {
                    employeeage = 0;
                }
                else
                {
                    employeeage = (int)jsonEmployees[i]["employee_age"];
                }
                if (String.IsNullOrWhiteSpace(Convert.ToString((int)jsonEmployees[i]["employee_salary"])))
                {
                    employeesalary = 0;
                }
                else
                {
                    employeesalary = (int)jsonEmployees[i]["employee_salary"];
                }
                if (String.IsNullOrWhiteSpace((string)jsonEmployees[i]["employee_name"]))
                {
                    employeename = "/";
                }
                else
                {
                    employeename = (string)jsonEmployees[i]["employee_name"];
                }
                employees.Add(new Employee
                {
                    Id = id,
                    employeeName = employeename,
                    employeeAge = employeeage,
                    employeeSalary = employeesalary
                });
            }
            return employees;
        }
        private string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }
    }
}
