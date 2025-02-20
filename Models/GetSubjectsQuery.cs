using CQRSMongoDB.Models;
using MediatR;

namespace CQRSWebAPI.Models
{
    public class GetSubjectsQuery : IRequest<List<SubjectsDTO>>
    {
    }
}
