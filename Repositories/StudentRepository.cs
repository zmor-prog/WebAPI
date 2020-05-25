using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Repositories
{
    public class StudentRepository
    {
        public Task<Student> Create(Student student)
        {
            

            var product = new Task<Student>(() =>
            {
                return new Student(student.FirstName, student.LastName, student.Age, student.Email, student.PhoneNumber);
            });
            return product;
        }

        public Task<Student> Read(Guid id)
        {
            var students = new List<Student>()
            {
               new Student("Aaron", "Aaronson", 18, "Aaronaronson@corn.cob", "555-555-5555"){ Id = new Guid("40f870d6-114d-471f-9746-fc5296cfbc93")},

               new Student("David", "Aaronson", 18, "Davidaronson@corn.cob", "555-555-5555"){ Id = new Guid("48ae1fe9-815f-4747-9958-5c9faf20c75f")},
            };
          

            var product = new Task<Student>(() =>
            {
                return students.Single<Student>(cookieMonster => cookieMonster.Id == id); 
            });
            return product;
        }
        // TODO this


        public Task<Student> Update(Student student)
        {
            var product = new Task<Student>(() =>
            {
                return new Student("Aaron", "Aaronson", 18, "Aaronaronson@corn.cob", "555-555-5555");
            });
            return product;
        }


        // TODO this
        public Task<Student> Delete(Guid id)
        {
            var product = new Task<Student>(() =>
            {
                return new Student("Aaron", "Aaronson", 18, "Aaronaronson@corn.cob", "555-555-5555");
            });
            return product;
        }
    }
}
