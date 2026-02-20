using UniversityEnrollmentSystem.Models;
using UniversityEnrollmentSystem.Repository.Students;

namespace UniversityEnrollmentSystem.Service.StudentService
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<Student> AddStudentAsync(Student student)
        {
            if (student == null)
                throw new Exception("Student is null");

            // optional rule: prevent duplicate email
            var existing = await _studentRepository.GetByEmailAsync(student.Email);

            if (existing != null)
                throw new Exception("Email already exists");

            await _studentRepository.AddStudentAsync(student);

            return student;
        }

        public async Task UpdateStudentAsync(Student student)
        {
            await _studentRepository.UpdateAsync(student);
        }

        public async Task DeleteStudentAsync(int id)
        {
            var student = await _studentRepository.GetByIdAsync(id);

            if (student == null)
                throw new Exception("Student not found");

            await _studentRepository.DeleteAsync(student);
        }

        public async Task<Student?> GetByIdAsync(int id)
        {
            return await _studentRepository.GetByIdAsync(id);
        }

        public async Task<List<Student>> GetAllAsync()
        {
            return await _studentRepository.GetAllAsync();
        }
    }
}