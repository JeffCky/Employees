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
        public int bonusPercentage { get; set; }

        public Employee(string firstName, string lastName, DateTime startDate, string title, double salary, int bonusPercentage)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.fullName = firstName + " " + lastName;
            this.startDate = startDate;
            this.title = title;
            this.salary = salary;
            this.bonusPercentage = bonusPercentage;
 
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

        public void CalculateRaise()
        {
            decimal raiseAmnt;
            
            try
            {
                raiseAmnt = (decimal)this.salary / this.bonusPercentage;
                Console.WriteLine("My raise will be {0}", string.Format("{0:C}", raiseAmnt));
               
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exception caught: {0}", ex.Message);
            }


        
            
        }
    }
}
