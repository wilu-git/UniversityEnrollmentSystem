using UniversityEnrollmentSystem.Models;

namespace UniversityEnrollmentSystem.Repository.Enrollments
{
    public interface IEnrollmentRepository
    {
        Task AddAsync(Enrollment enrollment);
        Task UpdateAsync(Enrollment enrollment);
        Task DeleteAsync(Enrollment enrollment);
        Task <Enrollment?> GetByIdAsync(int id);
        Task <List<Enrollment>> GetAllAsync();
        Task<bool> ExistsAsync(int studentId, int courseId);
        Task GetCourseWithEnrollmentsAsync(int courseId);
        Task DeleteAsync(int id);
    }
}
