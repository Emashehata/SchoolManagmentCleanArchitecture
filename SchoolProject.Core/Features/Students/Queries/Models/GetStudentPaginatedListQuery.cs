using MediatR;
using SchoolProject.Core.Features.Students.Queries.Results;
using SchoolProject.Core.Wrappers;

namespace SchoolProject.Core.Features.Students.Queries.Models
{
    public class GetStudentPaginatedListQuery : IRequest<PaginatedResult<GetStudentPaginatedLIstResponse>>
    {
        public int PageNumber { get; set; }
        public int Pagesize { get; set; }
        public string[]? OrderBY { get; set; }
        public string? Search { get; set; }
    }
}
