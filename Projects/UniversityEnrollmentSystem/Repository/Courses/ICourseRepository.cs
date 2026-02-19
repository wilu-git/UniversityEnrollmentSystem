using UniversityEnrollmentSystem.Models;

namespace UniversityEnrollmentSystem.Repository.Courses
{
    public interface ICourseRepository
    {
        Task AddCourseAsync(Course course);
        Task Update(Course course);
        Task Delete(Course course);
        Task <Course?> GetByIdAsync(int id);
        Task <List<Course>> GetAllAsync();
    }
}
