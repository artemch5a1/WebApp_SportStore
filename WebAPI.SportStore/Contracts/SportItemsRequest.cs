namespace WebAPI.SportStore.Contracts
{
    public record SportItemsRequest(
        string Title,
        string Description,
        decimal Price
        );
}
