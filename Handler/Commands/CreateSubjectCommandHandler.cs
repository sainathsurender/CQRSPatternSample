using CQRSMongoDB.Models;
using CQRSMongoDB.Repositories;
using CQRSWebAPI.Models;
using MediatR;

namespace CQRSWebAPI.Handler.Commands
{
    public class CreateSubjectCommandHandler : IRequestHandler<CreateSubjectCommand, bool>
    {
        private readonly ISubjectRepository _repository;

        public CreateSubjectCommandHandler(ISubjectRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(CreateSubjectCommand request, CancellationToken cancellationToken)
        {
            var newId = _repository.InsertSubject(new SubjectsDTO(request.Id, request.Name, request.Description));
            return await Task.FromResult(newId);
        }
    }
}
