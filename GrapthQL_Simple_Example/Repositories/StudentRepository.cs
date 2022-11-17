using GrapthQL_Simple_Example.Models;

namespace GrapthQL_Simple_Example.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public List<student> GetAllStudents()
        {
            return new List<student>() { new student() { Id = 1, Name = "Ahmed", Marks = 15 }, new student() { Id = 2, Name = "Mohamed", Marks = 30 }, new student() { Id = 3, Name = "Karem", Marks = 50 } };
        }
    }
}
