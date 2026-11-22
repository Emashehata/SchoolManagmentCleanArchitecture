using AutoMapper;
using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Students.Commands.Models;
using SchoolProject.Data.Entities;
using SchoolProject.Service.Abstraction;

namespace SchoolProject.Core.Features.Students.Commands.Handlers
{

    public class StudentCommandHandler :
        ResponseHandler, IRequestHandler<AddStudentCommand, Response<string>>,
        IRequestHandler<EditStudentCommand, Response<string>>
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        public StudentCommandHandler(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }
        public async Task<Response<string>> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            var studentMapper = _mapper.Map<Student>(request);
            var res = await _studentService.AddStuentAsync(studentMapper);
            if (res == "Exist") return UnprocessableEntity<string>("Name is exist");

            else if (res == "Success") return Created("Aded Successfully");
            else return BadRequest<string>();
        }

        public async Task<Response<string>> Handle(EditStudentCommand request, CancellationToken cancellationToken)
        {
            var student = _studentService.GetStudentByIdAsync(request.Id);
            if (student == null) return NotFound<string>("Student doensot exist");
            var studentmapper = _mapper.Map<Student>(request);
            var res = await _studentService.EditStudentAsync(studentmapper);
            if (res == "Success") return Success($"Edit Successfully{studentmapper.StudID}");
            else return BadRequest<string>();

        }
    }
}
