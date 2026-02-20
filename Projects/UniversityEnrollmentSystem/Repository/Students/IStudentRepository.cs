using UniversityEnrollmentSystem.Models;

namespace UniversityEnrollmentSystem.Repository.Students
{
    public interface IStudentRepository
    {
        Task AddStudentAsync(Student student);
        Task UpdateAsync(Student student);
        Task DeleteAsync(Student student);
        Task <Student?> GetByIdAsync(int id);
        Task <List<Student>> GetAllAsync();

        Task<Student?> GetByEmailAsync(string email);
        Task<bool> StudentNumberExistsAsync(string studentNumber);
    }
}
