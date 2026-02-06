using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// using Entities;
using DAL;
using Entities;
using DTO;
using System.Net;

namespace Controller;

[Route("api/[controller]/[action]")]
[ApiController]
public class CategoriesControllers:ControllerBase
{
    private readonly ToDoAppDBContext _context;

    public CategoriesControllers(ToDoAppDBContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<IActionResult> GetAllCategories()
    {
        return Ok(await _context.Categories.ToListAsync());
    }

    [HttpGet]
    public async Task<IActionResult> GetByIdCategory(int id)
    {
        return Ok(await _context.Categories.FirstOrDefaultAsync(e => e.Id==id));
    }

    [HttpPost]
    public async Task<IActionResult> CreateNewCategory(CreateCategoryDto dto)
    {
        Category newcategory = new Category();
        newcategory.Name = dto.Name;
        _context.Categories.Add(newcategory);
        _context.SaveChanges();
        return Ok(HttpStatusCode.Created);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateSelectedCategory(int id, UpdateCategoryDto dto)
    {
        var updated = await _context.Categories.FirstOrDefaultAsync(e => e.Id==id);
        updated.Name = dto.Name;
        _context.SaveChanges();
        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteSelectedCategory(int id)
    {
        var deleted = await _context.Categories.FirstOrDefaultAsync(e => e.Id==id);
        _context.Categories.Remove(deleted);
        _context.SaveChanges();
        return Ok();
    }
}
