using SchoolProject.Data.Entities;
using SchoolProject.Infrastructure.Abstraction.Interfaces;
using SchoolProject.Service.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
