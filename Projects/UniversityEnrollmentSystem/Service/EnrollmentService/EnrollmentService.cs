using UniversityEnrollmentSystem.Models;
using UniversityEnrollmentSystem.Repository.Enrollments;

namespace UniversityEnrollmentSystem.Service.EnrollmentService
{
    public class EnrollmentService : IEnrollmentService
    {
        private readonly IEnrollmentRepository _enrollmentRepository;

        public EnrollmentService(IEnrollmentRepository enrollmentRepository)
        {
            _enrollmentRepository = enrollmentRepository;
        }

        public async Task<Enrollment> EnrollAsync(int studentId, int courseId)
        {
            var course = await _enrollmentRepository.GetCourseWithEnrollmentsAsync(courseId);

            if (course == null)
                throw new Exception("Course not found");

            bool alreadyExists =
                await _enrollmentRepository.ExistsAsync(studentId, courseId);

            if (alreadyExists)
                throw new Exception("Student already enrolled");


            var today = DateTime.Today;

            
            var enrollment = new Enrollment
            {
                StudentId = studentId,
                CourseOfferingId = courseId,
                Grade = 0
            };

            await _enrollmentRepository.AddAsync(enrollment);

            return enrollment;
        }

        public async Task DeleteCourseOfferingAsync(int id)
        {
            var enrollment = await _enrollmentRepository.GetByIdAsync(id);

            if (enrollment == null)
                throw new Exception("Course not found");

            //if (course.Enrollments.Any())
            //    throw new Exception("Cannot delete course if enrollments exist");

            await _enrollmentRepository.DeleteAsync(enrollment);
        }

        public Task<Enrollment> EnrollStudentAsync(int studentId, int courseOfferingId)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateGradeAsync(int enrollmentId, int grade)
        {

            if (grade < 0 || grade > 100)
                throw new Exception("Grade must be between 0 and 100");

            var enrollment = await _enrollmentRepository.GetByIdAsync(enrollmentId);

            if (enrollment == null)
                throw new Exception("Enrollment not found");

            enrollment.Grade = grade;

            await _enrollmentRepository.UpdateAsync(enrollment);
        }
    }
}
