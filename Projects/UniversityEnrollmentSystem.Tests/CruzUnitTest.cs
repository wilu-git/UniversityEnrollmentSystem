using Moq;
using Xunit;
using UniversityEnrollmentSystem.Models;
using UniversityEnrollmentSystem.Repository.CourseOfferings;
using UniversityEnrollmentSystem.Service.CourseOfferingService;

namespace UniversityEnrollmentSystem.Tests
{

    public class CruzUnitTest
    {
        private readonly Mock<ICourseOfferingRepository> _courseOfferingRepo;
        private readonly ICourseOfferingService _courseOfferingService; 

        public CruzUnitTest()
        {
            _courseOfferingRepo = new Mock<ICourseOfferingRepository>();
            //_courseOfferingService = new CourseOfferingService(_courseOfferingRepo.Object);
        }

        [Fact]
        public void AddStudent_ShouldInsertRecord()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void StudentNumber_ShouldBeUnique()
        {
            throw new NotImplementedException();
        }
        [Fact]
        public void CourseCode_ShouldBeUnique()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void CourseOffering_ShouldBeUnique_PerSemester()
        {
            throw new NotImplementedException();
        }
        [Fact]
        public void Enrollment_ShouldBeUnique_PerStudentOffering()
        {
            throw new NotImplementedException();
        }

        [Fact] 
        public void DeleteCourse_ShouldFail_WhenEnrollmentsExist()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void Repository_GetById_ShouldReturnNull_WhenInvalid()
        {
            throw new NotImplementedException();
        }
        [Fact] 
        public void UpdateCourse_ShouldPersistChanges()
        {
            throw new NotImplementedException();
        }
        [Fact] 
        public void ForeignKey_ShouldPreventInvalidEnrollment()
        {
            throw new NotImplementedException();
        }
        [Fact] 
        public void RequiredFields_ShouldRejectNull()
        {
            throw new NotImplementedException();
        }



    }
}
