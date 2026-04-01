namespace BookAPI.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string? ImageURL { get; set; }
        public int CategoryId { get; set; }
    }
}
