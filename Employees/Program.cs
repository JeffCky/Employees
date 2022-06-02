using System;
using System.Collections;
using System.Collections.Generic;

namespace Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            printInfo();
            
        }

        public static void printInfo()
        {
            List<Employee> AllEmployees = new List<Employee>();
            AllEmployees.Add(new Employee("Bill", "Smith", DateTime.Parse("11-01-1965") , "male", DateTime.Parse("12-01-2021"), "Director", 46250.10, 0));
            AllEmployees.Add(new Employee("Joe", "Green", DateTime.Parse("12-01-1962"), "male", DateTime.Now, "Sales Rep", 95250.10, 4));
            AllEmployees.Add(new Employee("Mike", "Stone", DateTime.Parse("11-21-1965"), "male", DateTime.Parse("11-21-2020"), "Custodian", 35250.10, 10));
            AllEmployees.Add(new Employee("Emily", "Jones", DateTime.Parse("10-01-1968"), "female", DateTime.Now, "President", 115250.1, 10));
            AllEmployees.Add(new Employee("Jeff", "Carter", DateTime.Parse("11-01-1965"), "male", DateTime.Now, "Vice President", 85250.10, 0));

            

            foreach (Employee emp in AllEmployees)
            {
                string text = ""; 
                
                emp.ShowFullName();
                emp.Working();

                switch (emp.Title)
                {
                    case ("Director"):
                        text = "updating our database";
                        break;
                    case ("Sales Rep"):
                        text = "my commission sheets";
                        break;
                    case ("Custodian"):
                        text = "cleaning the foyer floors";
                        break;
                    case ("President"):
                        text = "a shareholder presentation";
                        break;
                    case ("Vice President"):
                        text = "a budget forecast";
                        break;
                    default:
                        break;
                }

                emp.Working(text);
                emp.ShowTitle();
                emp.ShowSalary();
                emp.CalculateRaise();
                emp.PayBonus();
                Console.WriteLine("---------------");
                Console.WriteLine();
                
                
                

            }





        }
    }
}
