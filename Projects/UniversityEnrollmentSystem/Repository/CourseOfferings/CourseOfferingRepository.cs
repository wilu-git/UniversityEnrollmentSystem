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

        public async Task UpdateAsync(CourseOffering courseOffer)
        {
            _context.CourseOfferings.Update(courseOffer);
            await _context.SaveChangesAsync();
        }
        
        public async Task DeleteAsync(CourseOffering courseOffer)
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

        public async Task<int> GetEnrollmentCountAsync(int courseOfferingId)
        {
            return await _context.Enrollments
                .CountAsync(e => e.CourseOfferingId == courseOfferingId);
        }

        public async Task<CourseOffering?> GetWithCourseAsync(int id)
        {
            return await _context.CourseOfferings
                .Include(o => o.Course)
                .FirstOrDefaultAsync(o => o.CourseId == id);
        }

        public async Task<bool> IsSemesterExpiredAsync(int offeringId)
        {
            var offering = await _context.CourseOfferings
                .FindAsync(offeringId);

            return offering != null && offering.EndDate < DateTime.UtcNow;
        }
    }

}
