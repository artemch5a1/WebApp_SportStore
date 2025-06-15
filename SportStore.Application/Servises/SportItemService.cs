using SportStore.Core.Abstractions;
using SportStore.Core.Models;


namespace SportStore.Application.Servises
{
    public class SportItemService : ISportItemService
    {
        private readonly ISportsItemsRepository _itemsRepository;

        public SportItemService(ISportsItemsRepository itemsRepository)
        {
            _itemsRepository = itemsRepository;
        }

        public async Task<List<SportsItem>> GetAllItems()
        {
            return await _itemsRepository.Get();
        }

        public async Task<Guid> CreateItem(SportsItem item)
        {
            return await _itemsRepository.Create(item);
        }

        public async Task<Guid> UpdateItem(Guid id, string title, string description, decimal price)
        {
            return await _itemsRepository.Update(id, title, description, price);
        }

        public async Task<Guid> DeleteItem(Guid id)
        {
            return await _itemsRepository.Delete(id);
        }
    }
}
