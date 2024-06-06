namespace DataAccess.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }  = string.Empty;   
        public string? Description { get; set; }
        public decimal? Price { get; set; }

        public virtual Brand Brand { get; set; } = new();   
    }
}
