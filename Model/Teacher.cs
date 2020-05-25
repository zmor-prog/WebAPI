using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
   public class Teacher : Person
    {
        public Teacher(string firstName, string lastName, int age, string email, string phoneNumber)
            : base(firstName, lastName, age, email, phoneNumber)
        { 
        
        }
    }
}
