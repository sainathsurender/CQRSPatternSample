using CQRSWebAPI.Models;
using CQRSWebAPI.Repositories;
using MediatR;

namespace CQRSWebAPI.Handler
{
    public class CreateItemCommandHandler : IRequestHandler<CreateItemCommand, int>
    {
        private readonly IItemRepository _repository;

        public CreateItemCommandHandler(IItemRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(CreateItemCommand request, CancellationToken cancellationToken)
        {
            var newId = _repository.Add(new ItemDto(0, request.Name, request.Description));
            return await Task.FromResult(newId);
        }
    }
}
