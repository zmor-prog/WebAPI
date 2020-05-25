using System;

namespace Model
{
    public class Student : Person
    {
        public Student(string firstName, string lastName, int age, string email, string phoneNumber): base(firstName, lastName, age, email, phoneNumber)
        {
          
        }
    }
}
