using TaskManager.Database;
using TaskManager.Database.Entities;

namespace TaskManager.DataAccessLayer.cs
{
    public interface ITaskRepository
    {
        public IEnumerable<CustomTask> GetTasks();

        public IEnumerable<Step> GetSteps(int taskId);

        public IEnumerable<Step> GetStepsByParentId( int parentStepId);
    }
}