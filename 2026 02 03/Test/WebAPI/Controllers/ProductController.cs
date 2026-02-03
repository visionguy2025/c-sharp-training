using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using DataAccessLayer;

namespace Controllers;

[Route("api/[contollers]")]
[ApiController]

public class ProductController:ControllerBase
{
    private readonly EFDbContext _context;
}
