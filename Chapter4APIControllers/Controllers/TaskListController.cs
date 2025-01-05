using Chapter4APIControllers.Models;
using Microsoft.AspNetCore.Mvc;

namespace Chapter4APIControllers.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TaskListController : ControllerBase
{
    private readonly ITodoBridge tasksBridge;

    public TaskListController(ITodoBridge tasksBridge)=>
        this.tasksBridge = tasksBridge;

    [HttpGet]
    public IActionResult Get()
    {
        var tasks = tasksBridge.GetAllTasks();
        return Ok(tasks);
    }

    [HttpPost]
    public IActionResult CreateTodo([FromBody] TaskEntity cretedTask)
    {
        tasksBridge.CreateTodo(cretedTask);
        return CreatedAtAction("Summary", cretedTask);
    }
}
