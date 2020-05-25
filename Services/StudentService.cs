using System;
using Repositories;
using Model;
using System.Threading.Tasks;

namespace Services
{
    public class StudentService
    {

        public StudentService(StudentRepository repository)
        {
            Repository = repository;
        }


        public StudentRepository Repository { get; set; }
        public Task<Student> Create(Student student)
        {
            var product = Repository.Create(student);
            return product;
        }

        public Task<Student> Read(Guid id)
        {
            var product = Repository.Read(id);
            return product;
        }

        public Task<Student> Update(Student student)
        {
            var product = Repository.Update(student);
            return product;
        }

        public Task<Student> Delete(Guid id)
        {
            var product = Repository.Delete(id);
            return product;
        }

    }
}
