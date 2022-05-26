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
            AllEmployees.Add(new Employee("Bill", "Smith", DateTime.Now, "Director", 46250.10));
            AllEmployees.Add(new Employee("Joe", "Green", DateTime.Now, "Sales Rep", 95250.10));
            AllEmployees.Add(new Employee("Mike", "Stone", DateTime.Now, "Custodian", 35250.10));
            AllEmployees.Add(new Employee("Emily", "Jones", DateTime.Now, "President", 115250.1));
            AllEmployees.Add(new Employee("Jeff", "Carter", DateTime.Now, "Vice President", 85250.10));

            

            foreach (Employee person in AllEmployees)
            {
                string text = ""; 
                
                Console.WriteLine(" " + " " + person.fullName + " says ... ");
                person.Working();

                switch (person.title)
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

                person.Working(text);
                person.ShowTitle();
                person.ShowSalary();
                Console.WriteLine("---------------");
                Console.WriteLine();
                
                
                

            }

            


        }
    }
}
