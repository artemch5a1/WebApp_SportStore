using Microsoft.AspNetCore.Mvc;
using SportStore.Core.Abstractions;
using SportStore.Core.Models;
using WebAPI.SportStore.Contracts;

namespace WebAPI.SportStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SportItemsController : ControllerBase
    {
        private readonly ISportItemService _itemService;

        public SportItemsController(ISportItemService ItemService)
        {
            _itemService = ItemService;
        }

        [HttpGet]
        public async Task<ActionResult<List<SportItemsResponse>>> GetSportItems()
        {
            var items = await _itemService.GetAllItems();

            var response = items.Select(b => new SportItemsResponse(b.Id, b.Title, b.Description, b.Price));

            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreateSportItem([FromBody] SportItemsRequest request)
        {
            var (item, error) = SportsItem.Create(Guid.NewGuid(), request.Title, request.Description, request.Price);

            if (!string.IsNullOrEmpty(error))
            {
                return BadRequest(error);
            }

            var id = await _itemService.CreateItem(item);

            return Ok(id);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<Guid>> UpdateSportItem(Guid id, [FromBody] SportItemsRequest request)
        {
            var (item, error) = SportsItem.Create(id, request.Title, request.Description, request.Price);

            if (!string.IsNullOrEmpty(error))
            {
                return BadRequest(error);
            }

            var responseId = await _itemService.UpdateItem(id, item.Title, item.Description, item.Price);

            return Ok(responseId);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<Guid>> DeleteSportItem(Guid id)
        {
            return await _itemService.DeleteItem(id);
        }
    }
}
