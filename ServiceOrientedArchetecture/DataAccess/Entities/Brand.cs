namespace DataAccess.Entities
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; 
        public string? Address { get; set; }

        public ICollection<Brand> Brands { get; set; } = new List<Brand>(); 
    }
}