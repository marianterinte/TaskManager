using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Business.BusinessEntities;
using TaskManager.DataAccessLayer.cs;

namespace TaskManager.Business
{
    public class TaskLoadHandler : ITaskLoadHandler
    {
        private ITaskRepository _taskRepository;

        public TaskLoadHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        // TODO Async all the way.

        public IEnumerable<CustomTask> GetTasks()
        {
            return _taskRepository.GetTasks().Select(s => new CustomTask()
            {
                Id = s.Id,
                Name = s.Name,
            });
        }

        public IEnumerable<Step> GetSteps(int taskId)
        {
            var owner = "anonymus";
            return _taskRepository.GetSteps(taskId).Select(s => new Step()
            {
                Id = s.Id,
                Label = $"{s.Name}-{s.Owner}",
            });
        }

        public IEnumerable<Step> GetStepsByParentId(int parentStepId)
        {
            return _taskRepository.GetStepsByParentId( parentStepId).Select(s => new Step()
            {
                Id = s.Id,
                Label = $"{s.Name}-{s.Owner}",
            });
        }
    }
}
