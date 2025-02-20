using CQRSWebAPI.Controllers;
using CQRSWebAPI.Models;
using CQRSWebAPI.Repositories;
using MediatR;

namespace CQRSWebAPI.Handler.Queries
{
    public class GetItemQueryHandler : IRequestHandler<GetItemQuery, ItemDto>
    {
        private readonly IItemRepository _repository;

        public GetItemQueryHandler(IItemRepository repository)
        {
            _repository = repository;
        }

        public async Task<ItemDto> Handle(GetItemQuery request, CancellationToken cancellationToken)
        {
            var item = _repository.GetById(request.Id);
            return await Task.FromResult(item);
        }
    }
}
