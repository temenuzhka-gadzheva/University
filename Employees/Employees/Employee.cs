using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
   public class Employee
    {
        private readonly List<Employee> employees;
        private string id;
        private string name;
        private decimal salary;
        public Employee()
        {
            this.ID = id;
            this.Name = name;
            this.Salary = salary;
            this.employees = new List<Employee>();
        }
        public string ID { get => this.id; set { this.id = value; } }
        public string Name { get => this.name; set { this.name = value; } }
        public decimal Salary { get => this.salary; set { this.salary = value; } }


        public void AddEmployee(Employee employee)
        {
            if (this.employees.Contains(employee))
            {
                throw new InvalidOperationException($"Employee with id:{employee.ID}already exist!");
            }
            this.employees.Add(employee);
        }
        public List<Employee> ShowEmployees => this.employees;
        public Employee ShowById(string id)
        {
            return this.employees.FirstOrDefault(e => e.ID == id);
        }
        public List<Employee> ShowBySalary(decimal salary)
        {
            return this.employees.Where(e => e.Salary > salary).ToList();
        }
        public void Save(BinaryWriter writer)
        {
            writer.Write(ID);
            writer.Write(Name);
            writer.Write(Salary);

        }

        public static Employee Read(BinaryReader reader)
        {
            Employee employee = new Employee();

            employee.ID = reader.ToString();
            employee.Name = reader.ToString();
            employee.Salary = reader.ReadDecimal();

            return employee;
        }
    }
}

