using Microsoft.EntityFrameworkCore;
using UniversityEnrollmentSystem.Models;

namespace UniversityEnrollmentSystem.Repository.CourseOfferings
{
    public class  CourseOfferingRepository(UniversityDbContext context) : ICourseOfferingRepository
    {
        private readonly UniversityDbContext _context = context;


        public async Task AddCourseOfferingAsync(CourseOffering courseOffer)
        {
             await _context.CourseOfferings.AddAsync(courseOffer);
            await _context.SaveChangesAsync();
        }

        public async Task Update(CourseOffering courseOffer)
        {
            _context.CourseOfferings.Update(courseOffer);
            await _context.SaveChangesAsync();
        }
        
        public async Task Delete(CourseOffering courseOffer)
        {
            _context.CourseOfferings.Remove(courseOffer);
            await _context.SaveChangesAsync();
        }

        public async Task<CourseOffering?> GetByIdAsync(int id)
        {
            return await _context.CourseOfferings.FindAsync(id);
        }

         public async Task<List<CourseOffering>> GetAllAsync()
        {
            return await _context.CourseOfferings.ToListAsync();
        }

        public async Task GetWithEnrollmentsAsync(int courseId)
        {
            await GetByIdAsync(courseId);
        }



    }

}
