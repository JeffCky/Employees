using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
   
    internal class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string fullName { get; set; }
        public DateTime startDate { get; set; }
        public string title { get; set; }
        public double salary { get; set; }

        public Employee(string firstName, string lastName, DateTime startDate, string title, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.fullName = firstName + " " + lastName;
            this.startDate = startDate;
            this.title = title;
            this.salary = salary;
        }

        public void Working()
        {
            Console.WriteLine("I am working.");
        }

        public void Working(string workingOn)
        {
            Console.WriteLine("I am working on {0}.", workingOn);
        }

        public void ShowTitle()
        {
            Console.WriteLine("My title is {0}", this.title);
        }

        public void ShowSalary()
        {
            Console.WriteLine("My salary is {0}", string.Format("{0:C}", this.salary));
        }
    }
}
