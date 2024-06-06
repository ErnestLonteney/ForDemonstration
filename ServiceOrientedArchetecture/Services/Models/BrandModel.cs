using DataAccess.Entities;

namespace Services.Models
{
    public class BrandModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Address { get; set; }

        public List<Brand> Brands { get; set; } = new();
    }
}
