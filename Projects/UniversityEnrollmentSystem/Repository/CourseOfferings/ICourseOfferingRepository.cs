using UniversityEnrollmentSystem.Models;

namespace UniversityEnrollmentSystem.Repository.CourseOfferings
{
    public interface ICourseOfferingRepository
    {
        Task AddCourseOfferingAsync(CourseOffering courseOffering);

        Task Update(CourseOffering courseOffer);

        Task Delete(CourseOffering courseOffer);

        Task <CourseOffering?> GetByIdAsync(int id);

        Task <List<CourseOffering>> GetAllAsync();
        Task DeleteAsync(int courseId);
        Task GetWithEnrollmentsAsync(int courseId);
    }
}
