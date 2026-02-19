using Microsoft.EntityFrameworkCore;
using UniversityEnrollmentSystem.Models;

namespace UniversityEnrollmentSystem.Repository.Courses
{
    public class CourseRepository(UniversityDbContext context) : ICourseRepository
    {
        private readonly UniversityDbContext _context = context;

        public async Task AddCourseAsync(Course course)
        {
            await _context.Courses.AddAsync(course);
        }   

        public async Task Update(Course course)
        {
            _context.Courses.Update(course);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Course course)
        {
            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
        }   

        public  async Task<Course?> GetByIdAsync(int id)
        {
            return await _context.Courses.FindAsync(id);
        }

        public async Task<List<Course>> GetAllAsync()
        {
            return await _context.Courses.ToListAsync();
        }

    }
}
