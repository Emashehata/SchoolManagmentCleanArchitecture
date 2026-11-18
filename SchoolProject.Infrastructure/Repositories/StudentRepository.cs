using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using SchoolProject.Infrastructure.Abstraction.Interfaces;
using SchoolProject.Infrastructure.Data;
using SchoolProject.Infrastructure.InfrastructureBases;

namespace SchoolProject.Infrastructure.Repositories
{
    public class StudentRepository :GenericRepositoryAsync<Student>, IStudentRepository
    {
        private readonly DbSet<Student> _students;

        public StudentRepository(ApplicationDbContext dbContext):base(dbContext)
        {
             _students=dbContext.Set<Student>();
        }

        public async Task<List<Student>> GetStudentListAsync()
        {
            return await _dbContext.students.Include(x=>x.Department).ToListAsync();
        }
    }
}
