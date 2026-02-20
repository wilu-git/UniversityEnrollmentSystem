using UniversityEnrollmentSystem.Models;

namespace UniversityEnrollmentSystem.Repository.Students
{
    public interface IStudentRepository
    {
        Task AddStudentAsync(Student student);
        Task Update(Student student);
        Task Delete(Student student);
        Task <Student?> GetByIdAsync(int id);
        Task <List<Student>> GetAllAsync();
        Task GetByEmailAsync(string? email);
    }
}
