using MyAPI.Models;

namespace MyAPI.Services.Interfaces;

public interface IProductService
{
    List<ProductModel> GetProducts();

    ProductModel? GetProduct(int id);

    public void DeleteProduct(int id);

    public void UpdateProduct(ProductModel forUpdate);

    public bool CreateProduct(ProductModel newProduct);
}
