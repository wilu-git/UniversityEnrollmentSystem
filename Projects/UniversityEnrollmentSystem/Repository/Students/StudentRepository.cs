using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;
using UniversityEnrollmentSystem.Models;

namespace UniversityEnrollmentSystem.Repository.Students
{
    public class StudentRepository(UniversityDbContext context) : IStudentRepository
    {
        private readonly UniversityDbContext _context = context;
        //private readonly UniversityDbContext _context = context;

        //public async Task AddStudentAsync(Student student)
        //{
        //    await _context.Students.AddAsync(student);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task UpdateAsync(Student student)
        //{
        //    _context.Students.Update(student);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(Student student)
        //{
        //    _context.Students.Remove(student);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task<Student?> GetByIdAsync(int id)
        //{
        //    return await _context.Students.FindAsync(id);
        //}
        // public async Task<List<Student>> GetAllAsync()
        //{
        //    return await _context.Students.ToListAsync();
        //}

        //public  async Task<Student?> GetByEmailAsync(string email)
        //{
        //    return await _context.Students.FirstOrDefaultAsync(s => s.Email == email);
        //}

        //public async Task<bool> StudentNumberExistsAsync(string studentNumber)
        //{
        //    return await _context.Students.AnyAsync(x => x.StudentNumber == studentNumber);
        //}

        //public Task Update(Student student)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task Delete(Student student)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task AddAsync(Student student)
        {
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
        }

        public async Task<Student?> GetByIdAsync(int id)
        {
            var student = await _context.Students.FirstOrDefaultAsync(x => x.StudentId == id);
            return student;
        
        }
        public async Task<Student?> GetByNameAsync(string name)
        {
            var student = await _context.Students.FirstOrDefaultAsync(x => x.FirstName == name || x.LastName == name);
            return student;

        }
            
        public async Task<IEnumerable<Student>> GetAllAsync()
        {
            var students = await _context.Students.ToListAsync();
            return students;
        }

        public async Task UpdateAsync(Student student)
        {
            _context.Students.Update(student);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var student = _context.Students.Where(x => x.StudentId == id);
            _context.Remove(student);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.Students.AnyAsync(x => x.StudentId == id);
        }
    }
}
