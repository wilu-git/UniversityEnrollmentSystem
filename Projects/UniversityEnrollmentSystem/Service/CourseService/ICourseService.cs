using UniversityEnrollmentSystem.Models;

namespace UniversityEnrollmentSystem.Service.CourseService
{
    public interface ICourseService
    {
        public Task GetCourseId(Course course);
    }
}
