using UniversityEnrollmentSystem.Models;

namespace UniversityEnrollmentSystem.Repository.Courses
{
    public interface ICourseRepository
    {
        //Task AddAsync(Course course);
        //Task Update(Course course);
        //Task Delete(Course course);
        //Task <Course?> GetByIdAsync(int id);
        //Task <List<Course>> GetAllAsync();


        //CRUD
        Task AddAsync(Course course);

        Task UpdateAsync(Course course);
        Task DeleteAsync(int id);

        Task <Course?> GetById(int id);
        Task <Course?> GetCourseByCourseCode(string courseCode);
        Task <Course?> GetByTitle(string title);
        Task<IEnumerable<Course>> GetAllAsync();

        Task<bool> ExistsAsync(int id);

    }
}
