using UniversityEnrollmentSystem.Models;
using UniversityEnrollmentSystem.Repository.CourseOfferings;

namespace UniversityEnrollmentSystem.Service.CourseOfferingService
{
    public class CourseOfferingService : ICourseOfferingService
    {
        private readonly ICourseOfferingRepository _courseRepository;

        public CourseOfferingService(ICourseOfferingRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }


        public async Task DeleteCourseOfferingAsync(int id)
        {
            throw new NotImplementedException();
            //var course = await _courseRepository.GetWithEnrollmentsAsync(id);

            //if (course == null)
            //    throw new Exception("Course not found");

            //if (course.Enrollments.Any())
            //    throw new Exception("Cannot delete course if enrollments exist");

            //await _courseRepository.DeleteAsync(id);
        }
    }
}

