using DataAccess.Entities;
using DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class BrandRepository: Repository<Brand>, IBrandRepository
    {
        private readonly MarketContext context;
        public BrandRepository(MarketContext marketContext)
            : base(marketContext)
        {
            context = marketContext;
        }
        public IEnumerable<Brand> GetBrandsWithProducts() =>
            context.Brands.Include(b => b.Brands).ToList();
        public IEnumerable<Brand> GetFullBrands() => context.Brands.ToList();
    }
}
