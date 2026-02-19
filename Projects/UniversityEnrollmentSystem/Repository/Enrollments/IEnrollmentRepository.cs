using UniversityEnrollmentSystem.Models;

namespace UniversityEnrollmentSystem.Repository.Enrollments
{
    public class IEnrollmentRepository
    {
        internal async Task AddAsync(Enrollment enrollment)
        {
            throw new NotImplementedException();
        }

        internal async Task<bool> ExistsAsync(int studentId, int courseId)
        {
            throw new NotImplementedException();
        }

        internal async Task GetByIdAsync(int enrollmentId)
        {
            throw new NotImplementedException();
        }

        internal async Task GetCourseWithEnrollmentsAsync(int courseId)
        {
            throw new NotImplementedException();
        }

        internal async Task UpdateAsync(object enrollment)
        {
            throw new NotImplementedException();
        }
    }
}
