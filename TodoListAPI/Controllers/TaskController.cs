using Microsoft.AspNetCore.Mvc;
using ToDoListProcess.Business;
using ToDoListProcess.Common;
using ToDoListProcess.DL;
using System.Collections.Generic;

namespace ToDoListAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskManagerController : ControllerBase
    {
        private readonly ToDoListManager taskManager;

        public TaskManagerController()
        {
            taskManager = new ToDoListManager(new DbTaskData());
        }

        [HttpGet("{username}")]
        public IEnumerable<TaskItem> GetTasks(string username) =>
            taskManager.GetAllTasks(username);

        [HttpPost("add")]
        public IActionResult Add([FromQuery] string username, [FromBody] string task)
        {
            return taskManager.AddTask(username, task) ? Ok("Added") : BadRequest("Failed");
        }

        [HttpPut("edit")]
        public IActionResult Edit([FromQuery] string username, [FromQuery] int index, [FromBody] string newTask)
        {
            return taskManager.EditTask(index, newTask, username) ? Ok("Edited") : BadRequest("Failed");
        }

        [HttpDelete("delete")]
        public IActionResult Delete([FromQuery] string username, [FromQuery] int index)
        {
            return taskManager.DeleteTask(index, username) ? Ok("Deleted") : NotFound();
        }

        [HttpPatch("done")]
        public IActionResult Done([FromQuery] string username, [FromQuery] int index)
        {
            return taskManager.MarkAsDone(index, username) ? Ok("Done") : NotFound();
        }

        [HttpGet("search")]
        public IEnumerable<TaskItem> Search([FromQuery] string username, [FromQuery] string keyword) =>
            taskManager.SearchTasks(keyword, username);
    }
}
