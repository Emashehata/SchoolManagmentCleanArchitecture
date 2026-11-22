using SchoolProject.Data.Entities;

namespace SchoolProject.Service.Abstraction
{
    public interface IStudentService
    {
        public Task<List<Student>> GetStudentsListAsync();
        public Task<Student> GetStudentByIdAsync(int stdId);
        public Task<string> AddStuentAsync(Student student);
        public Task<bool> IsNameExist(string name);
        public Task<bool> IsNameExistExcludeSelf(string name, int id);
        public Task<string> EditStudentAsync(Student student);
    }
}
