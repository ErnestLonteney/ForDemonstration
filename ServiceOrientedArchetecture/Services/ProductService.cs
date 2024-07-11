using AutoMapper;
using DataAccess.Repositories;
using DataAccess.Repositories.Interfaces;
using Services.Interfaces;
using Services.Models;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository repository;
        private readonly IMapper mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            repository = productRepository;
            this.mapper = mapper;
        }

        public IEnumerable<ProductModel> GetProductsThatHavePrices()
        {
            var dbProducts = repository.GetProductsWithPrices();

            return mapper.Map<IEnumerable<ProductModel>>(dbProducts);             
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
