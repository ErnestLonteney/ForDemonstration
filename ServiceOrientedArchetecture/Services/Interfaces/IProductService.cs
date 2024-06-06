using DataAccess.Repositories;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IProductService
    {
        IEnumerable<ProductModel> GetProductsThatHavePrices();

        IEnumerable<ProductModel> GetProducts();
    }
}
