using Database.Entities;
using MyAPI.Models;
using MyAPI.Services.Interfaces;

namespace MyAPI.Services;

public class ProductService(ProductStoreContext productStoreContext) : IProductService
{
    public List<ProductModel> GetProducts()
    {
        var products = productStoreContext.Products.ToList();

        var list = products.Select(p => new ProductModel
        {
            Id = p.Id,
            Name = p.Name,
            Articul = p.Articul,
            Category = p.Category,
            Description = p.Description
        }).ToList();

        return list; 
    }


    public ProductModel? GetProduct(int id)
    {
        var result = productStoreContext.Products.Find(id);

        return (result is null) ? new() :
            new ProductModel
            {
                Id = id,
                Description = result.Description,
                Articul = result.Articul,
                Category = result.Category,
                Name = result.Name
            };
    }

    public void DeleteProduct(int id)
    {
        var product = productStoreContext.Products.Find(id);

        if (product is not null)
            productStoreContext.Products.Remove(product);

        productStoreContext.SaveChanges();
    }

    public void UpdateProduct(ProductModel forUpdate)
    {
        var product = productStoreContext.Products.Find(forUpdate.Id);

        if (product is not null)
        {
            product.Articul = forUpdate.Articul;
            product.Name = forUpdate.Name;
            product.Category = forUpdate.Category;
            product.Description = forUpdate.Description;
        }

        productStoreContext.SaveChanges();
    }

    public bool CreateProduct(ProductModel newProduct)
    {
        var productDb = new Product
        {
            Name = newProduct.Name,
            Description = newProduct.Description,
            Articul = newProduct.Articul,
            Category = newProduct.Category,
        };

        try
        {
            productStoreContext.Products.Add(productDb);
            productStoreContext.SaveChanges();

            return true;
        }
        catch (Exception ex)
        {
            return false;
        }                  
    }
}
