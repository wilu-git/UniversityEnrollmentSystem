using UniversityEnrollmentSystem.Models;

namespace UniversityEnrollmentSystem.Repository.Students
{
    public interface IStudentRepository
    {
        //Task AddStudentAsync(Student student);
        //Task UpdateAsync(Student student);
        //Task DeleteAsync(Student student);
        //Task <Student?> GetByIdAsync(int id);
        //Task <List<Student>> GetAllAsync();

        //Task<Student?> GetByEmailAsync(string email);
        //Task<bool> StudentNumberExistsAsync(string studentNumber);
        //Task Update(Student student);
        //Task Delete(Student student);

        //CRUD

        Task AddAsync(Student student);

        Task<Student?> GetByIdAsync(int id);
        Task<Student?> GetByNameAsync(string name);

        Task<IEnumerable<Student>> GetAllAsync();
       
        Task UpdateAsync(Student student);

        Task DeleteAsync(int id);

        Task<bool> ExistsAsync(int id); 
    }
}
