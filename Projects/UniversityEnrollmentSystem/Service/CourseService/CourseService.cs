using UniversityEnrollmentSystem.Models;
using UniversityEnrollmentSystem.Repository.Courses;

namespace UniversityEnrollmentSystem.Service.CourseService
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task GetCourseId(Course course)
        {
            throw new NotImplementedException();
        }

    }
}
