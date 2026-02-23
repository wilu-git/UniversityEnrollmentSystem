using UniversityEnrollmentSystem.Models;

namespace UniversityEnrollmentSystem.Repository.Enrollments
{
    public interface IEnrollmentRepository
    {
        //Task AddAsync(Enrollment enrollment);
        //Task UpdateAsync(Enrollment enrollment);
        //Task DeleteAsync(Enrollment enrollment);
        //Task <Enrollment?> GetByIdAsync(int id);
        //Task <List<Enrollment>> GetAllAsync();
        //Task<bool> ExistsAsync(int studentId, int courseId);
        //Task <Course> GetCourseWithEnrollmentsAsync(int courseId);

        Task AddAsync(Enrollment enrollment);
        Task UpdateAsync(Enrollment enrollment);
        Task DeleteAsync(int id);

        Task<Enrollment?> GetById(int id);
        Task<IEnumerable<Enrollment?>?> GetAllAsync();


        Task<IEnumerable<Enrollment>> GetByStudentIdAsync(int studentId);

        Task<IEnumerable<Enrollment>> GetByCourseOfferingId(int courseOfferingId);

        Task <bool> Exists(int studentId, int courseOfferingId);

    }
}
