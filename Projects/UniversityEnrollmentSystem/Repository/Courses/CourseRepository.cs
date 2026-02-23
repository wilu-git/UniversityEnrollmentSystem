using Microsoft.EntityFrameworkCore;
using UniversityEnrollmentSystem.Models;

namespace UniversityEnrollmentSystem.Repository.Courses
{
    public class CourseRepository(UniversityDbContext context) : ICourseRepository
    {
        private readonly UniversityDbContext _context = context;

        //public async Task AddAsync(Course course)
        //{
        //    await _context.Courses.AddAsync(course);
        //    await _context.SaveChangesAsync();
        //}   

        //public async Task Update(Course course)
        //{
        //    _context.Courses.Update(course);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task Delete(Course course)
        //{
        //    _context.Courses.Remove(course);
        //    await _context.SaveChangesAsync();
        //}   

        //public  async Task<Course?> GetByIdAsync(int id)
        //{
        //    return await _context.Courses.FindAsync(id);
        //}

        //public async Task<List<Course>> GetAllAsync()
        //{
        //    return await _context.Courses.ToListAsync();
        //}


        public async Task AddAsync(Course course)
        {
            _context.Courses.Add(course);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Course course)
        {
            _context.Courses.Update(course);
            await _context.SaveChangesAsync();

        }
        public async Task DeleteAsync(int id)
        {
            var course = await _context.Courses.FirstOrDefaultAsync(x => x.CourseId == id);
            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
        }

        public async Task<Course?> GetById(int id)
        {
            var course = await _context.Courses.FirstOrDefaultAsync(x => x.CourseId.Equals(id));
            return course;
        }
        public async Task<Course?> GetCourseByCourseCode(string courseCode)
        {
            var course = await _context.Courses.FirstOrDefaultAsync(x => x.CourseCode == courseCode);
            return course;
        }
        public async Task<Course?> GetByTitle(string title)
        {
            var course = await _context.Courses.Where(x => x.Title == title).FirstOrDefaultAsync();
            return course;
        }
        public async Task<IEnumerable<Course>> GetAllAsync()
        {
            var courses = await _context.Courses.ToListAsync();
            return courses;
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.Courses.AnyAsync(x=> x.CourseId == id);
        }
    }
}
