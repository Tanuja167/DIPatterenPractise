using DIPatterenPractise.Models;

namespace DIPatterenPractise.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetStudents();

        Student GetStudentById(int id);

        int AddStudent(Student student);
        int UpdateStudent(Student student);
        int DeleteStudent(int id);

    }
}
