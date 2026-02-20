using UniversityEnrollmentSystem.Models;

namespace UniversityEnrollmentSystem.Service.EnrollmentService
{
    public interface IEnrollmentService
    {
     
        Task<Enrollment> EnrollStudentAsync(int studentId, int courseOfferingId);

        Task UpdategradeAsync(int enrollmentId, int grade);

        Task DeleteCourseOfferingAsync(int id);
    }
}
