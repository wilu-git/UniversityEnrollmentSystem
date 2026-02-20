using UniversityEnrollmentSystem.Models;

namespace UniversityEnrollmentSystem.Repository.Semester
{
    public class SemesterRepository(UniversityDbContext context) : ISemesterRepository
    {
        private readonly UniversityDbContext _context = context;
        
    }
}
