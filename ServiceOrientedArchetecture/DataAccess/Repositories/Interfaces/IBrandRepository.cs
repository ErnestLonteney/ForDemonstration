using DataAccess.Entities;

namespace DataAccess.Repositories.Interfaces;

interface IBrandRepository : IRepository<Brand>
{
    IEnumerable<Brand> GetBrandsWithProducts();
    IEnumerable<Brand> GetFullBrands();
}
