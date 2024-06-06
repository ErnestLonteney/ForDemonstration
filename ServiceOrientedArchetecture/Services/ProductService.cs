using DataAccess.Repositories;
using DataAccess.Repositories.Interfaces;
using Services.Interfaces;
using Services.Models;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository repository;

        public ProductService(IProductRepository productRepository)
        {
            repository = productRepository;    
        }

        public IEnumerable<ProductModel> GetProductsThatHavePrices()
        {
            var dbProducts = repository.GetProductsWithPrices();

            return dbProducts.Select(e => new ProductModel
            {
                Price = e.Price,    
                Brand = new BrandModel
                {
                    Name = e.Brand.Name,
                    Address = e.Brand.Address,
                    Id = e.Brand.Id,
                },
                Description = e.Description,
                Id = e.Id
            });
        }

        public IEnumerable<ProductModel> GetProducts()
        {
            var dbProducts = repository.GetAll();

            return dbProducts.Select(e => new ProductModel
            {
                Price = e.Price,
                Brand = new BrandModel
                {
                    Name = e.Brand.Name,
                    Address = e.Brand.Address,
                    Id = e.Brand.Id,
                },
                Description = e.Description,
                Id = e.Id
            });
        }
    }
}
