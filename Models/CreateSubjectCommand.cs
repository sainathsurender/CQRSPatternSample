using MediatR;

namespace CQRSWebAPI.Models
{
    public record CreateSubjectCommand(int Id, string Name, string Description) : IRequest<bool>;
}
