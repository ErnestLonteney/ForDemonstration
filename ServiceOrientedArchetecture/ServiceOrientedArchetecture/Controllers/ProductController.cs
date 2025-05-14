using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ServiceOrientedArchetecture.Models;
using Services.Interfaces;

namespace ServiceOrientedArchetecture.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly IMapper mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            this.productService = productService;
            this.mapper = mapper;   
        }

        [HttpGet]
        public IActionResult Index()
        {
            var products = productService.GetProducts().ToList();

            var mapped = mapper.Map<IEnumerable<ProductModelView>>(products);

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
