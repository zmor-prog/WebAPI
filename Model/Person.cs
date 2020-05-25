using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Person 
    {
        public Guid Id{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public List<Course> Courses { get; set; }

        public Person(string firstName, string lastName, int age, string email, string phoneNumber) 
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
