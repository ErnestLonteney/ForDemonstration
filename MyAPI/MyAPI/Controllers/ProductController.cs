using Microsoft.AspNetCore.Mvc;
using MyAPI.Models;
using MyAPI.Services.Interfaces;

namespace MyAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController(IProductService service) : Controller
    {
        private readonly IProductService service = service;

        [HttpGet("list")]
        public IActionResult GetAll() 
        {
            var result = service.GetProducts();

            if (result is not null)
                return Ok(result);

            return BadRequest();
        }

        [HttpGet("{productId}")]
        public IActionResult Get(int productId)
        {
            var product = service.GetProduct(productId);

            if (product is not null)
                return Ok(product);

            return BadRequest();

        }
        
        // api/product/create
        [HttpPost("create")]
        public IActionResult Create(ProductModel product)
        {
            bool result = service.CreateProduct(product);

            if (result)
                return Ok(product);

            return BadRequest();
        }

        [HttpPut("update")]
        public IActionResult Update(ProductModel product)
        {
           service.UpdateProduct(product);
          
           return Ok(product);
        }

        [HttpDelete("{productId}")]
        public IActionResult Delete(int productId)
        {
           service.DeleteProduct(productId);   

           return Ok();
        }

    }
}
