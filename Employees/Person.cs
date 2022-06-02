using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }

        public string Gender { get; set; }  

        public DateTime DateOfBirth { get; set; }   

        public Person(string firstName, string lastName, DateTime dateOfBirth, string gender)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FullName = firstName + " " + lastName;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;

        }

        
    }

    
}
