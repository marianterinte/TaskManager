using TaskManager.Database;
using TaskManager.Database.Entities;

namespace TaskManager.DataAccessLayer.cs
{
    public class TaskRepository: ITaskRepository
    {
        public IEnumerable<CustomTask> GetTasks()
        {
            var query = from t in FakeDatabase.Tasks
                        select t;

            return query;
        }

        //TODO Move into step repository
        public IEnumerable<Step> GetSteps(int taskId)
        {
            var query = from s in FakeDatabase.Steps
                        where taskId == s.TaskId
                        && s.ParentStepId==0
                        select s;
           
            return query;
        }

        public IEnumerable<Step> GetStepsByParentId( int parentStepId)
        {
            var query = from s in FakeDatabase.Steps
                        where s.ParentStepId== parentStepId
                        select s;

            var query2 = from parent in FakeDatabase.Steps
                         where parent.ParentStepId==parentStepId
                         join child in FakeDatabase.Steps
                         on child.ParentStepId equals parent.Id
                         group by parent.Id 
                         select new() {
                         Id=parent.Id,

                         }
                         
                
                select 
  parent.Id, parent.title, count(child.id) 'number of children' 
from
  ttt parent left join ttt child
    on child.parent = parent.id
group by parent.id
order by parent.id;




           
            return query;
        }
    }
}