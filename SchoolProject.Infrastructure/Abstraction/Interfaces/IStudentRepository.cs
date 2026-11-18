using SchoolProject.Data.Entities;
using SchoolProject.Infrastructure.InfrastructureBases;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject.Infrastructure.Abstraction.Interfaces
{
    public interface IStudentRepository:IGenericRepositoryAsync<Student>
    {
        public Task<List<Student>> GetStudentListAsync();
    }
}
