using CQRSWebAPI.Models;

namespace CQRSWebAPI.Repositories
{
    public interface IItemRepository
    {
        int Add(ItemDto item);
        ItemDto GetById(int id);
    }
}
