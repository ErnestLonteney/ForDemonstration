namespace ServiceOrientedArchetecture.Models
{
    public class ProductAggrigated
    {
        public ProductModelView Product { get; set; } = new();
        public string Code { get; set; } = string.Empty;
    }
}
