using UniversityEnrollmentSystem.Models;

namespace UniversityEnrollmentSystem.Service.StudentService
{
    public interface IStudentService
    {
        Task<Student> AddStudentAsync(Student student);

        Task UpdateStudentAsync(Student student);

        Task DeleteStudentAsync(int id);

        Task<Student?> GetByIdAsync(int id);

        Task<List<Student>> GetAllAsync();
    }
}
