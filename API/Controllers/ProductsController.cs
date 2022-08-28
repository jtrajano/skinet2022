using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _repo;

        public ProductsController(IProductRepository repo)
        {
      
            _repo = repo;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id){

            var product = await _repo.GetProduct(id);

            return Ok(product);
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<Product>>> GetProducts(){

            var products = await _repo.GetProducts();

            return Ok(products);

        }

    }
}