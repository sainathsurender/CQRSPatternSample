using CQRSWebAPI.Models;
using CQRSWebAPI.Repositories;

namespace CQRSWebAPI.Data
{
    public class ItemRepository : IItemRepository
    {
        private readonly List<ItemDto> _items = new();
        private int _nextId = 1;

        public int Add(ItemDto item)
        {
            var newItem = item with { Id = _nextId++ };
            _items.Add(newItem);
            return newItem.Id;
        }

        public ItemDto GetById(int id)
        {
            return _items.FirstOrDefault(item => item.Id == id) ?? throw new KeyNotFoundException("Item not found");
        }
    }
}
