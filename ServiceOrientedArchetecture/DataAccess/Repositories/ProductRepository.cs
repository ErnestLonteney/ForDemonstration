using DataAccess.Entities;
using DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories;
public class ProductRepository : Repository<Product>, IProductRepository
{
    private readonly MarketContext context;

    public ProductRepository(MarketContext marketContext)
        : base(marketContext)   
    {
        context = marketContext;   
    }

    public IEnumerable<Product> GetProductsWithPrices() => 
        context.Products.Where(p => p.Price.HasValue).ToList();

    public IEnumerable<Product> GetFullProducts() => context.Products.Include(p => p.Brand).ToList();
}
