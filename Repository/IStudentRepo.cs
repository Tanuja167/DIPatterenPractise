using DIPatterenPractise.Models;

namespace DIPatterenPractise.Repository
{
    public interface IStudentRepo
    {

        IEnumerable<Student> GetStudents();

        Student GetStudentById(int id);

        int AddStudent(Student student);

        int UpdateStudent(Student student);

        int DeleteStudent(int id);
    }
}
