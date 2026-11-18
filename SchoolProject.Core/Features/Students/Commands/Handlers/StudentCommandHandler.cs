using AutoMapper;
using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Students.Commands.Models;
using SchoolProject.Service.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject.Core.Features.Students.Commands.Handlers
{
     
    public class StudentCommandHandler : ResponseHandler, IRequestHandler<AddStudentCommand, Response<string>>
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        public Task<Response<string>> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
             var studentMapper=_mapper.Map
        }
    }
}
