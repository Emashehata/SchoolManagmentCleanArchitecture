using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using SchoolProject.Infrastructure.Abstraction.Interfaces;
using SchoolProject.Service.Abstraction;

namespace SchoolProject.Service.Implemeentaions
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<List<Student>> GetStudentsListAsync()
        {
            return await _studentRepository.GetStudentListAsync();
        }

        public async Task<Student> GetStudentByIdWithIncludeAsync(int stdId)
        {
            //var student= await _studentRepository.GetStudentByIdAsync(stdId);
            var student = _studentRepository.GetTableNoTracking().Include(x => x.Department)
                                                                .Where(x => x.StudID.Equals(stdId))
                                                                .FirstOrDefault();
            return student;
        }

        public async Task<string> AddStuentAsync(Student student)
        {
            var studentExists = await _studentRepository
                .GetTableNoTracking()
                .AnyAsync(x => x.Name == student.Name);

            if (studentExists)
                return "Exist";

            await _studentRepository.AddAsync(student);

            return "Success";
        }

        public async Task<bool> IsNameExist(string name)
        {
            var student = _studentRepository.GetTableNoTracking().Where(x => x.Name.Equals(name)).FirstOrDefault();
            if (student == null) return false;
            return true;
        }

        public async Task<bool> IsNameExistExcludeSelf(string name, int id)
        {
            var student = await _studentRepository.GetTableNoTracking().Where(x => x.Name.Equals(name) & !x.StudID.Equals(id)).FirstOrDefaultAsync();
            if (student == null) return false;
            return true;
        }

        public async Task<string> EditStudentAsync(Student student)
        {
            await _studentRepository.UpdateAsync(student);
            return "Success";
        }

        public async Task<string> DeleteStudentAsync(Student student)
        {
            var trans = _studentRepository.BeginTransaction();
            try
            {
                await _studentRepository.DeleteAsync(student);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Failed";
            }

        }

        public async Task<Student> GetStudentByIdAsync(int stdId)
        {
            var std = await _studentRepository.GetByIdAsync(stdId);
            return std;
        }
    }
}
