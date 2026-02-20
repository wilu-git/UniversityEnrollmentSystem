using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using UniversityEnrollmentSystem.Repository.Enrollments;
using UniversityEnrollmentSystem.Service.EnrollmentService;

namespace UniversityEnrollmentSystem.Tests.ServiceTests
{
    public class EnrollmentServiceTests
    {
        private readonly Mock<IEnrollmentRepository> _mockRepo;
        private readonly IEnrollmentService _enrollmentService;

        public EnrollmentServiceTests()
        {
            _mockRepo = new Mock<IEnrollmentRepository>();
            _enrollmentService = new EnrollmentService(_mockRepo.Object);
        }


    }
}
