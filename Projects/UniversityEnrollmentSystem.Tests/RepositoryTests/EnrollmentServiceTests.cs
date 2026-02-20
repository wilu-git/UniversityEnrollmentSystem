using Moq;
using Xunit;
using UniversityEnrollmentSystem.Models;
using UniversityEnrollmentSystem.Repository.Enrollments;
using UniversityEnrollmentSystem.Service.EnrollmentService;

public class EnrollmentServiceTests
{
    private readonly Mock<IEnrollmentRepository> _repo;
    private readonly EnrollmentService _service;
    private object? result;

    public EnrollmentServiceTests()
    {
        _repo = new Mock<IEnrollmentRepository>();
        _service = new EnrollmentService(_repo.Object);
    }
   
    [Fact]
    public async Task EnrollStudent_ShouldFail_WhenCourseIsFull()
    {
        var course = new CourseOffering
        {
            Capacity = 1,
            Enrollments = new List<Enrollment> { new Enrollment() }
        }

        _repo.Setup(r => r.GetCourseWithEnrollmentsAsync(1))
             .ReturnsAsync(course);

        await Assert.ThrowsAsync<Exception>(() =>
            _service.EnrollAsync(1, 1));
    }

    private void ReturnsAsync(CourseOffering course)
    {
        throw new NotImplementedException();
    }

    [Fact]
    public async Task EnrollStudent_ShouldFail_WhenAlreadyEnrolled()
    {
        _repo.Setup(r => r.ExistsAsync(1, 1))
             .ReturnsAsync(true);

        await Assert.ThrowsAsync<Exception>(() =>
            _service.EnrollAsync(1, 1));
    }

    [Fact]
    public async Task EnrollStudent_ShouldSucceed_WhenValid()
    {
        var course = new CourseOffering
        {
            Capacity = 5,
            Enrollments = new List<Enrollment>(),
            StartDate = DateTime.Today.AddDays(-1),
            EndDate = DateTime.Today.AddDays(10)
        };

       // _repo.Setup(r => r.GetCourseWithEnrollmentsAsync(1)).ReturnsAsync(course);
       // _repo.Setup(r => r.ExistsAsync(1, 1)).ReturnsAsync(false);

        //var result = await _service.EnrollAsync(1, 1);

        Assert.NotNull(result);
    }

    [Fact]
    public async Task EnrollStudent_ShouldFail_WhenSemesterExpired()
    {
        var course = new CourseOffering
        {
            Capacity = 5,
            Enrollments = new List<Enrollment>(),
            StartDate = DateTime.Today.AddDays(-10),
            EndDate = DateTime.Today.AddDays(-5)
        };

       // _repo.Setup(r => r.GetCourseWithEnrollmentsAsync(1)).ReturnsAsync(course);

        await Assert.ThrowsAsync<Exception>(() =>
            _service.EnrollAsync(1, 1));
    }

    [Fact]
    public async Task AssignGrade_ShouldFail_WhenNotEnrolled()
    {
        _repo.Setup(r => r.GetByIdAsync(1)).ReturnsAsync((Enrollment?)null);

        await Assert.ThrowsAsync<Exception>(() =>
            _service.AssignGradeAsync(1, 90));
    }

    [Fact]
    public async Task AssignGrade_ShouldFail_WhenGradeOutOfRange()
    {
        await Assert.ThrowsAsync<Exception>(() =>
            _service.AssignGradeAsync(1, 200));
    }

    [Fact]
    public async Task AssignGrade_ShouldSucceed_WhenValid()
    {
        _repo.Setup(r => r.GetByIdAsync(1)).ReturnsAsync(new Enrollment());

        await _service.AssignGradeAsync(1, 95);

        _repo.Verify(r => r.UpdateAsync(It.IsAny<Enrollment>()), Times.Once);
    }
}

