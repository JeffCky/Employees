using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
   
    internal class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public DateTime StartDate { get; set; }
        public string Title { get; set; }
        public double Salary { get; set; }

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
            Console.WriteLine("My title is {0}", this.Title);
        }

        public void ShowSalary()
        {
            Console.WriteLine("My salary is {0}", string.Format("{0:C}", this.Salary));
        }
    }
}
