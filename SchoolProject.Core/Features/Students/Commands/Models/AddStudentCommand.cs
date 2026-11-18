using Azure;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolProject.Core.Features.Students.Commands.Models
{
    public class AddStudentCommand:IRequest<Response<>>
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [StringLength(500)]
        public string Phone { get; set; }
        public int DepartmentId {  get; set; }

    }
}
