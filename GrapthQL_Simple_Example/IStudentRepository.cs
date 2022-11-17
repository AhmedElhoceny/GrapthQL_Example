using GrapthQL_Simple_Example.Models;

namespace GrapthQL_Simple_Example
{
    public interface IStudentRepository
    {
        List<student> GetAllStudents();
    }
}
