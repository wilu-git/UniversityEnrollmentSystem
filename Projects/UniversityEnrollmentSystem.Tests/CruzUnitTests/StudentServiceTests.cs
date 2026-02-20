using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using UniversityEnrollmentSystem.Models;
using UniversityEnrollmentSystem.Repository.Students;
using UniversityEnrollmentSystem.Service.StudentService;
using Xunit;

namespace UniversityEnrollmentSystem.Tests.CruzUnitTests
{
    public class StudentServiceTests
    {
        private readonly Mock<IStudentRepository> _mockRepo;
        private readonly IStudentService _studentService;

        public StudentServiceTests()
        {
            _mockRepo = new Mock<IStudentRepository>();
            //_studentService = new StudentService(_mockRepo.Object);
        }

        private Student CreateValidStudent()
        {
            return new Student
            {
                FirstName = "Venalouie",
                LastName = "Cruz",
                StudentNumber = "2024-001",
                Email = "Venalouiec@gmail.com"
            };
        }

        [Fact]
        public void AddStudent_ShouldInsertRecord()
        {
            throw new NotImplementedException();
            //var student = CreateValidStudent();

            //_mockRepo.Setup(r => r.StudentNumberExistsAsync(student.StudentNumber))
            //         .ReturnsAsync(false);

            //_mockRepo.Setup(r => r.AddStudentAsync(student))
            //         .Returns(Task.CompletedTask);

            //await _studentService.AddStudentAsync(student);

            //// Assert
            //_mockRepo.Verify(r => r.AddStudentAsync(student), Times.Once);

        }
        [Fact]
        public void StudentNumber_ShouldBeUnique()
        {
            throw new NotImplementedException();
            //var student = CreateValidStudent();

            //_mockRepo.Setup(r => r.StudentNumberExistsAsync(student.StudentNumber))
            //         .ReturnsAsync(true);

            //await Assert.ThrowsAsync<Exception>(() =>
            //    _studentService.AddStudentAsync(student));
        }

    }
}
