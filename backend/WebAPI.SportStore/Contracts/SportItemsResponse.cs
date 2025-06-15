namespace WebAPI.SportStore.Contracts
{
    public record SportItemsResponse(
        Guid Id,
        string Title,
        string Description,
        decimal Price
        );
}
