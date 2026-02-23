using UniversityEnrollmentSystem.Models;

namespace UniversityEnrollmentSystem.Repository.CourseOfferings
{
    public interface ICourseOfferingRepository
    {
        Task AddAsync(CourseOffering courseOffering);

        Task UpdateAsync(CourseOffering courseOffer);

        Task DeleteAsync(CourseOffering courseOffer);

        Task <CourseOffering?> GetByIdAsync(int id);

        Task <List<CourseOffering>> GetAllAsync();

        Task<int> GetEnrollmentCountAsync(int courseOfferingId);

        Task<CourseOffering?> GetWithCourseAsync(int id);
    }
}
