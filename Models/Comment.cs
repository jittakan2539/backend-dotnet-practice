namespace backend_dotnet_practice.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.now;
        public int? StockId { get; set; }
        //Navigation
        public int Stock { get; set; }
    }
}