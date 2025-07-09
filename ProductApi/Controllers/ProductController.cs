using Microsoft.EntityFrameworkCore;
using ProductApi.Models;
using ProductApi.Data;
using Microsoft.AspNetCore.Mvc;
namespace ProductApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context) => _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAll()
        {
            return await _context.Products.ToListAsync();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return Ok(product);
        }
    }
}

