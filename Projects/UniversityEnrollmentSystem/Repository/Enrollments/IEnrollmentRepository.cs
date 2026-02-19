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
    }
}
