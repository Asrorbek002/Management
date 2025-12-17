using Management.Domain.Models;
using Management.Infrastucture.Data;

namespace Management.Application.Services
{
    public class StudentService
    {
        public DbContext DbContext { get; set; }

        public StudentService()
        {
            this.DbContext = new DbContext();  
        }
        public void AddStudent(string firstName, string lastName)
        {
            Student newStudent = new Student
            {
                Id = new Random ().Next(1,1000).ToString(),
                Firstname = firstName,
                Lastname = lastName,
            };

            this.DbContext.Students[0] = newStudent;
        }
    }
}
