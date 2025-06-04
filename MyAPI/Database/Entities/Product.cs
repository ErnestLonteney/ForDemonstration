namespace Database.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public string Category { get; set; } = "Common";

        public string Articul { get; set; } = "00000";
    }
}
