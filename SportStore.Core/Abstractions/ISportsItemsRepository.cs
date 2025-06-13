using SportStore.Core.Models;

namespace SportStore.Core.Abstractions
{
    public interface ISportsItemsRepository
    {
        Task<Guid> Create(SportsItem Item);
        Task<Guid> Delete(Guid id);
        Task<List<SportsItem>> Get();
        Task<Guid> Update(Guid id, string title, string description, decimal price);
    }
}