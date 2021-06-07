using System;
using System.Collections.Generic;
using System.IO;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
             {
                 new Employee() { ID = "123",Name = "Alex", Salary = 2500 },
                 new Employee() {  ID = "345",Name = "Stamat", Salary = 3800},
                 new Employee() {  ID = "567",Name = "Marty", Salary = 1900 },
                 new Employee() {  ID = "789",Name = "Pepy", Salary = 7000 },
             };
            // SaveToFile(employees, @"D:\OOP2\Demo3105");
            // Print(employees);
        }
        static void Print(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"Id: {employee.ID}, Name:{employee.Name}, salary:{employee.Salary}");
            }
            Console.WriteLine("---------------------------");
        }
        static void SaveToFile(List<Employee> employees, string fileName)
        {
            try
            {
                using (Stream fs = File.Create(fileName))
                {
                    using (var writer = new BinaryWriter(fs))
                    {
                        writer.Write(employees.Count);
                        foreach (var employee in employees)
                        {
                            employee.Save(writer);
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error writing file: {ex.Message}");
            }
        }

        static List<Employee> readLineFromFile(string fileNmae)
        {
            List<Employee> employees = new List<Employee>();

            try
            {
                using (Stream fs = File.OpenRead(fileNmae))
                {
                    using (BinaryReader reader = new BinaryReader(fs))
                    {
                        int count = reader.ReadInt32();
                        for (int i = 0; i < count; i++)
                        {
                            employees.Add(Employee.Read(reader));
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file:{ex.Message}");
            }
            return employees;
        }
    }
}
