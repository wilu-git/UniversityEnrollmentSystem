using Microsoft.EntityFrameworkCore;
using UniversityEnrollmentSystem.Models;

namespace UniversityEnrollmentSystem.Repository.Enrollments
{
    public class EnrollmentRepository(UniversityDbContext context) : IEnrollmentRepository
    {
        private readonly UniversityDbContext _context = context;
    

        public async Task AddEnrollmentAsync(Enrollment enrollment)
        {
            await _context.Enrollments.AddAsync(enrollment);
        }

        public async Task Update(Enrollment enrollment)
        {
            _context.Enrollments.Update(enrollment);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Enrollment enrollment)
        {
            _context.Enrollments.Remove(enrollment);
            await _context.SaveChangesAsync();
        }

        public async Task<Enrollment?> GetByIdAsync(int id)
        {
            return await _context.Enrollments.FindAsync(id);
        }
         public async Task<List<Enrollment>> GetAllAsync()
        {
            return await _context.Enrollments.ToListAsync();
        }

    }
}
