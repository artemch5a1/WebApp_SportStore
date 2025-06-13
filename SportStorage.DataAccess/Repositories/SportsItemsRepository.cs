using Microsoft.EntityFrameworkCore;
using SportStorage.DataAccess.Entites;
using SportStore.Core.Models;
using SportStore.Core.Abstractions;

namespace SportStorage.DataAccess.Reposotories
{
    public class SportsItemsRepository : ISportsItemsRepository
    {
        private readonly SportStorageDbContext _context;

        public SportsItemsRepository(SportStorageDbContext context)
        {
            this._context = context;
        }

        public async Task<List<SportsItem>> Get()
        {
            var ItemsEntity = await _context.SportsItems
                .AsNoTracking()
                .ToListAsync();

            var SprotsItems = ItemsEntity
                .Select(x => SportsItem.Create(x.Id, x.Title, x.Description, x.Price).sportsItem)
                .ToList();

            return SprotsItems;
        }

        public async Task<Guid> Create(SportsItem Item)
        {
            var ItemEntity = new SportsItemEntity
            {
                Id = Item.Id,
                Title = Item.Title,
                Description = Item.Description,
                Price = Item.Price
            };

            await _context.SportsItems.AddAsync(ItemEntity);

            await _context.SaveChangesAsync();

            return ItemEntity.Id;
        }

        public async Task<Guid> Update(Guid id, string title, string description, decimal price)
        {
            await _context.SportsItems
                .Where(i => i.Id == id)
                .ExecuteUpdateAsync(s => s
                  .SetProperty(i => i.Title, i => title)
                  .SetProperty(i => i.Description, id => description)
                  .SetProperty(i => i.Price, i => price));

            await _context.SaveChangesAsync();

            return id;
        }

        public async Task<Guid> Delete(Guid id)
        {
            await _context.SportsItems.Where(i => i.Id == id).ExecuteDeleteAsync();

            return id;
        }
    }
}
