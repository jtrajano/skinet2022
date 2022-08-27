using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    private readonly StoreContext _context;
    public ProductsController(StoreContext context)
    {
            _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetProducts()
    {
        var product = await _context.Products.ToListAsync();

        return Ok(product);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetProduct(int id){
        var product = await _context.Products.FindAsync(id);

        return Ok(product);
    }
}
