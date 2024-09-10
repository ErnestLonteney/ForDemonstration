using DataAccess.Entities;
using System.ComponentModel.DataAnnotations;

namespace ServiceOrientedArchetecture.Models
{
    public class BrandModelView
    {
        [StringLength(50)]
        [Display(Name="Name of brand")]
        public string Name { get; set; } = string.Empty;
        public string? Address { get; set; }

        public List<Brand> Brands { get; set; } = new();
    }
}
