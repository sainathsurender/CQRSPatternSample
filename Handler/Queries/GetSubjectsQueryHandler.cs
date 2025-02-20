using CQRSMongoDB.Models;
using CQRSMongoDB.Repositories;
using CQRSWebAPI.Controllers;
using CQRSWebAPI.Models;
using CQRSWebAPI.Repositories;
using MediatR;

namespace CQRSWebAPI.Handler.Queries
{
    public class GetSubjectsQueryHandler : IRequestHandler<GetSubjectsQuery, List<SubjectsDTO>>
    {
        private readonly ISubjectRepository _repository;

        public GetSubjectsQueryHandler(ISubjectRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<SubjectsDTO>> Handle(GetSubjectsQuery request, CancellationToken cancellationToken)
        {
            var subjects = _repository.GetAllSubjects();
            return await Task.FromResult(subjects);
        }
    }
}