using MediatR;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Business;
using TaskManager.Business.BusinessEntities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ITaskLoadHandler _taskLoadHandler;

        public TaskController(IMediator mediator, ITaskLoadHandler taskLoadHandler)
        {
            _mediator = mediator;
            _taskLoadHandler = taskLoadHandler;
        }



        // GET: api/<TaskController>
        [HttpGet]
        public IEnumerable<CustomTask> LoadTasks()
        {
            return _taskLoadHandler.GetTasks();
        }

        // GET api/<TaskController>/5
        [HttpGet("{taskId}")]
        public IEnumerable<Step> LoadSteps(int taskId)
        {
           return _taskLoadHandler.GetSteps(taskId);
        }

        // Maybe to move into StepController
        // GET api/<TaskController>/5
        [HttpGet("step/{parentStepId}")]
        public IEnumerable<Step> LoadStepChildren(int parentStepId)
        {
            return _taskLoadHandler.GetStepsByParentId( parentStepId);
        }

    }
}
