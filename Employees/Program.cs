using System;
using System.Collections;

namespace Employees
{
    internal class Program
    {
        public static ArrayList employees = new ArrayList()
        {
            "Bill", "Smith", "Bill Smith", DateTime.Now, "Director", 46250.10,
            "Joe", "Green", "Joe Green", DateTime.Now, "Sales Rep", 95250.10,
            "Mike", "Stone", "Mike Stone", DateTime.Now, "Custodian", 35250.10,
            "Emily", "Jones", "Emily Jones", DateTime.Now, "President", 115250.10,
            "Jeff", "Carter",  "Jeff Carter", DateTime.Now, "Vice President", 85250.10
        };
        static void Main(string[] args)
        {
            Employee bill = new Employee();
            bill.FirstName = (string)employees[0];
            bill.LastName = (string)employees[1];
            bill.FullName = (string)employees[2];
            bill.StartDate = (DateTime)employees[3];
            bill.Title = (string)employees[4];
            bill.Salary = (double)employees[5];

            Employee joe = new Employee();
            joe.FirstName = (string)employees[6];
            joe.LastName = (string)employees[7];
            joe.FullName = (string)employees[8];
            joe.StartDate = (DateTime)employees[9];
            joe.Title = (string)employees[10];
            joe.Salary = (double)employees[11];

            Employee mike = new Employee();
            mike.FirstName = (string)employees[12];
            mike.LastName = (string)employees[13];
            mike.FullName = (string)employees[14];
            mike.StartDate = (DateTime)employees[15];
            mike.Title = (string)employees[16];
            mike.Salary = (double)employees[17];

            Employee emily = new Employee();
            emily.FirstName = (string)employees[18];
            emily.LastName = (string)employees[19];
            emily.FullName = (string)employees[20];
            emily.StartDate = (DateTime)employees[21];
            emily.Title = (string)employees[22];
            emily.Salary = (double)employees[23];

            Employee jeff = new Employee();
            jeff.FirstName = (string)employees[24];
            jeff.LastName = (string)employees[25];
            jeff.FullName = (string)employees[26];
            jeff.StartDate = (DateTime)employees[27];
            jeff.Title = (string)employees[28];
            jeff.Salary = (double)employees[29];

            printInfo(bill, "updating database");
            printInfo(joe, "my commission sheets"); 
            printInfo(mike, "cleaning the foyer floors"); 
            printInfo(emily, "my stockholders presentation");
            printInfo(jeff, "our budget forecast");
        }

        public static void printInfo(Employee name, string workingOn)
        {
            Console.WriteLine(" " + name.FirstName +" says ... ");
            name.Working();
            name.Working(workingOn);
            name.ShowTitle();
            name.ShowSalary();
            Console.WriteLine("---------------");
            Console.WriteLine();

        }
    }
}
