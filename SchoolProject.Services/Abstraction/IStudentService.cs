using SchoolProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject.Service.Abstraction
{
    public interface IStudentService
    {
        public Task<List<Student>> GetStudentsListAsync();
    }
}
