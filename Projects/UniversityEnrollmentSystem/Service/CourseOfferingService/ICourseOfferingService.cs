using UniversityEnrollmentSystem.Models;

namespace UniversityEnrollmentSystem.Service.CourseOfferingService
{
    public interface ICourseOfferingService
    {
        Task AddCourseOfferingAsync(CourseOffering courseOffering);

        Task<CourseOffering?> GetCourseOfferingByIdAsync(int id);

        Task<List<CourseOffering>> GetAllCourseOfferingsAsync();

 
        Task DeleteCourseOfferingAsync(int id);
    }
}