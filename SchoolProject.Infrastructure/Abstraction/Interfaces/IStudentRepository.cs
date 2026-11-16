using SchoolProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject.Infrastructure.Abstraction.Interfaces
{
    public interface IStudentRepository
    {
        public Task<List<Student>> GetStudentListAsync();
    }
}
