using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.Models
{
    public class Employee
    {
        // VAriables
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Age { get; set; }

        List<Employee> employeesList = new List<Employee>();

        // AddEmployee
        public void AddEmployee(string name, string eamil, int age)
        {
            employeesList.Add(new Employee { Name = name, Email = eamil, Age = age });
        }
        // GetEmployee
        public void GetEmployees() { 
            foreach(var element in employeesList)
            {
                Console.WriteLine($"{element.Name}\t\t{element.Email}\t{element.Age}");
            }
        }

        // get; and set;
        private string emailAddr;
        public string EmailAddr
        {
            get
            {
                return emailAddr;
            }
            set
            {
                if (value.Contains('@') || value.Contains('.'))
                {
                    emailAddr = value;
                }
                else Console.WriteLine("Invalid email address!");
            }
        }

        public void GetEmail()
        {
            Console.WriteLine($"Your valid email is: {emailAddr}");
        }
    }
}
