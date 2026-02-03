using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using DAL;

namespace Controller;

[Route("api/[controller]")]
[ApiController]
public class ProductController:ControllerBase
{
    private readonly EcomDbContext _context;

    public ProductController(EcomDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllProducts()
    {
        return View(await _context.Products.ToListAsync());
    }
}
