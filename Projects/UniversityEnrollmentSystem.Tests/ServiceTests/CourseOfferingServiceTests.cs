using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using UniversityEnrollmentSystem.Repository.CourseOfferings;
using UniversityEnrollmentSystem.Repository.Students;
using UniversityEnrollmentSystem.Service.CourseOfferingService;
using UniversityEnrollmentSystem.Service.StudentService;
using Xunit;

namespace UniversityEnrollmentSystem.Tests.ServiceTests
{
    public class CourseOfferingServiceTests
    {

        private readonly Mock<ICourseOfferingRepository> _mockRepo;
        private readonly ICourseOfferingService _courseOfferingService;

        public CourseOfferingServiceTests()
        {
            _mockRepo = new Mock<ICourseOfferingRepository>();
            //_courseOfferingService = new CourseOfferingService(_mockRepo.Object); 
        }

        [Fact]
        public void CourseOffering_ShouldBeUnique_PerSemester()
        {
            throw new NotImplementedException();
        }



    }
}
