using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using UniversityEnrollmentSystem.Repository.Courses;
using UniversityEnrollmentSystem.Service.CourseService;
using Xunit;

namespace UniversityEnrollmentSystem.Tests.ServiceTests
{
    public class CourseServiceTests
    {
        private readonly Mock<ICourseRepository> _mockRepo;
        private readonly ICourseService _courseService;

        public CourseServiceTests()
        {
            _mockRepo = new Mock<ICourseRepository>();
            _courseService = new CourseService(_mockRepo.Object);
        }

    }
}
