using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практическая_работа__7_модули
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public string Role { get; set; }

        public static List<Employee> employees = new List<Employee>();
        public void addEmployee(Employee employee)
        {
            employees.Add(employee);
        }
    }
}
