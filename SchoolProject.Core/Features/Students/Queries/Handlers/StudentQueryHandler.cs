using AutoMapper;
using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Students.Queries.Models;
using SchoolProject.Core.Features.Students.Queries.Results;
using SchoolProject.Data.Entities;
using SchoolProject.Service.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject.Core.Features.Students.Queries.Handlers
{
    public class StudentQueryHandler :ResponseHandler
        , IRequestHandler<GetStudentListQuery,Response<List<GetStudentListResponse>>>
        , IRequestHandler<GetStudentByIDQuery, Response<GetStudentByIDResponse>>
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        public StudentQueryHandler(IStudentService studentService,IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }
        public async Task<Response<List<GetStudentListResponse>>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            var StudentList= await _studentService.GetStudentsListAsync();
            var StudentListMapper = _mapper.Map<List<GetStudentListResponse>>(StudentList);
            return Success(StudentListMapper);
        }
        public async Task<Response<GetStudentByIDResponse>> Handle(GetStudentByIDQuery request, CancellationToken cancellationToken)
        {
            var student = await _studentService.GetStudentByIdAsync(request.Id);
            if (student == null) 
            { 
                return NotFound<GetStudentByIDResponse>("Object not found");
            }
            var result = _mapper.Map<GetStudentByIDResponse>(student);
            return Success(result);
        }
    }
}
