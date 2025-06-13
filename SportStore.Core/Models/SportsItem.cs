namespace SportStore.Core.Models
{
    public class SportsItem
    {
        public const int MAX_TITLE_LENGTH = 200;

        private SportsItem(Guid id, string title, string description, decimal price)
        {
            Id = id;
            Title = title;
            Description = description;
            Price = price;
        }

        public Guid Id { get; }

        public string Title { get; } = string.Empty;

        public string Description { get; } = string.Empty;

        public decimal Price { get; } = decimal.Zero;

        public static (SportsItem sportsItem, string Error) Create(Guid id, string title, string description, decimal price)
        {
            var error = string.Empty;

            if (string.IsNullOrEmpty(title) || title.Length > 200)
            {
                error = "Title must not be empty and must be less than 200 characters";
            }

            var sportsItem = new SportsItem(id, title, description, price);

            return (sportsItem, error);
        }
    }
}
