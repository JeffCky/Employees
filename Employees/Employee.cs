using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Employees
{
   
    internal class Employee : Person
    {
       
        public DateTime StartDate { get; set; }
        public string Title { get; set; }
        public double Salary { get; set; }
        public int BonusPercentage { get; set; }

        public Employee(string firstName, string lastName, DateTime dateOfBirth, string gender, DateTime startDate, string title, double salary, int bonusPercentage) :base(firstName, lastName, dateOfBirth, gender)
        {
            this.StartDate = startDate;
            this.Title = title;
            this.Salary = salary;
            this.BonusPercentage = bonusPercentage;
 
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
            Console.WriteLine("My title is {0}", this.Title);
        }

        public void ShowSalary()
        {
            Console.WriteLine("My salary is {0}", string.Format("{0:C}", this.Salary));
        }

        public void ShowFullName()
        {
            Console.WriteLine("My full name is {0}", this.FullName);
        }

        public void CalculateRaise()
        {
            decimal raiseAmnt;
            
            try
            {
                raiseAmnt = (decimal)this.Salary / this.BonusPercentage;
                Console.WriteLine("My raise will be {0}", string.Format("{0:C}", raiseAmnt));
               
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("There will be no raise in pay: {0}, ", ex.Message);
            }


        
            
        }
        public bool IsEligibleForRaise()
        {
            TimeSpan workTime = DateTime.Today - StartDate;
            if ( workTime.Days > 180)
                return true;
            else
                return false;
        }

        public void PayBonus()
        {
            int bonusPercent = 25;
            double bonus = 0;
            if (IsEligibleForRaise())
            {
                bonus = this.Salary / bonusPercent;
                Console.WriteLine("My bonus will be {0}", bonus);
            }
            else
            {
                Console.WriteLine("I have not worked here for six months yet, so I will not receive a bonus.");
            }

        }
    }
}
