using SportStore.Core.Models;

namespace SportStore.Core.Abstractions
{
    public interface ISportItemService
    {
        Task<Guid> CreateItem(SportsItem item);
        Task<Guid> DeleteItem(Guid id);
        Task<List<SportsItem>> GetAllItems();
        Task<Guid> UpdateItem(Guid id, string title, string description, decimal price);
    }
}