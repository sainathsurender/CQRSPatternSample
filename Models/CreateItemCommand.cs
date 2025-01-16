using MediatR;

namespace CQRSWebAPI.Models
{
    public record CreateItemCommand(string Name, string Description) : IRequest<int>;
}
