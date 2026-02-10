using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using DataAccessLayer;
using Entities;

namespace MyApp.Namespace
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TasksCtrl : ControllerBase
    {
        private readonly TMdbContext _context;

        public TasksCtrl(TMdbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTasks()
        {
            List<GetAllTasksDto> result = new List<GetAllTasksDto>(0);
            var allTasks = await _context.Tasks.ToListAsync();
            foreach(ETask task in allTasks)
            {
                GetAllTasksDto dto = new GetAllTasksDto();
                dto.Title = task.Title;
                dto.Text = task.Text;
                result.Add(dto);
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTaskById(int id)
        {
            GetAllTasksDto dto = new GetAllTasksDto();
            var selectedTask = await _context.Tasks.FirstOrDefaultAsync(t => t.Id==id);
            if(selectedTask == null)
            {
                return BadRequest((int)HttpStatusCode.NotFound);
            }
            dto.Title = selectedTask.Title;
            dto.Text = selectedTask.Text;
            return Ok(dto);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTask(CreateTaskDto dto)
        {
            ETask newTask = new ETask();
            newTask.Title = dto.Title;
            newTask.Text = dto.Text;
            await _context.Tasks.AddAsync(newTask);
            await _context.SaveChangesAsync();
            return Ok((int)HttpStatusCode.Created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTask(int id, UpdateTaskDto dto)
        {
            var updatedTask = await _context.Tasks.FirstOrDefaultAsync(t => t.Id==id);
            if(updatedTask == null)
            {
                return BadRequest((int)HttpStatusCode.NotFound);
            }
            updatedTask.Title = dto.Title;
            updatedTask.Text = dto.Text;
            await _context.SaveChangesAsync();
            return Ok((int)HttpStatusCode.OK);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            var selectedTask = await _context.Tasks.FirstOrDefaultAsync(t => t.Id==id);
            if(selectedTask == null)
            {
                return BadRequest((int)HttpStatusCode.NotFound);
            }
            _context.Tasks.Remove(selectedTask);
            await _context.SaveChangesAsync();
            return Ok((int)HttpStatusCode.OK);
        }
    }
}
