using AuthDemo.Dtos;
using AuthDemo.Models;
using AuthDemo.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthDemo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private static readonly List<AppUser> _users = new(); // ← In-memory DB for demo
    private readonly JwtService _jwtService;

    public AuthController(JwtService jwtService)
    {
        _jwtService = jwtService;
    }

    [HttpPost("register")]
    public IActionResult Register([FromBody] RegisterDto dto)
    {
        if (_users.Any(u => u.Email == dto.Email))
            return BadRequest("Email already exists");

        var user = new AppUser
        {
            Email = dto.Email,
            FullName = dto.FullName,
            PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password)
        };

        _users.Add(user);

        return Ok(new { message = "User registered", userId = user.Id });
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginDto dto)
    {
        var user = _users.FirstOrDefault(u => u.Email == dto.Email);

        if (user is null || !BCrypt.Net.BCrypt.Verify(dto.Password, user.PasswordHash))
            return Unauthorized("Invalid credentials");

        var token = _jwtService.GenerateToken(user);

        return Ok(new
        {
            token,
            user = new { user.Id, user.Email, user.FullName, user.Roles }
        });
    }

    // ────────────────────────────────────────────────
    //              Protected route example
    // ────────────────────────────────────────────────

    [Authorize]
    [HttpGet("profile")]
    public IActionResult GetProfile()
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var email = User.FindFirstValue(ClaimTypes.Email);
        var name = User.FindFirstValue(ClaimTypes.Name);
        var roles = User.FindAll(ClaimTypes.Role).Select(c => c.Value);

        return Ok(new
        {
            userId,
            email,
            name,
            roles
        });
    }
}
