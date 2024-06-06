using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Interfaces;

namespace ServiceOrientedArchetecture.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;    
        }

        [HttpGet]
        public IActionResult Index()
        {
            var products = productService.GetProducts().ToList();
            return View(products);
        }

        [HttpGet("with-prices")]
        public IActionResult GetProductsWithPrices()
        {
            try
            {
                var products = productService.GetProductsThatHavePrices();
                return View(products);
            }
            catch (Exception ex)
            {
                return NotFound();  
            }
        }

    }
}
