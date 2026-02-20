using UniversityEnrollmentSystem.Models;

namespace UniversityEnrollmentSystem.Repository.Enrollments
{
    public interface IEnrollmentRepository
    {
        Task AddEnrollmentAsync(Enrollment enrollment);
        Task Update(Enrollment enrollment);
        Task Delete(Enrollment enrollment);
        Task <Enrollment?> GetByIdAsync(int id);
        Task <List<Enrollment>> GetAllAsync();
        Task AddAsync(Enrollment enrollment);
        Task UpdateAsync(Enrollment enrollment);
        Task<bool> ExistsAsync(int studentId, int courseId);
        Task GetCourseWithEnrollmentsAsync(int courseId);
    }
}
