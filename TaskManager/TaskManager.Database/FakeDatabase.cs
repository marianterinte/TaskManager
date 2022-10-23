using TaskManager.Database.Entities;

namespace TaskManager.Database
{
    public static class FakeDatabase
    {
        static IEnumerable<CustomTask> _tasks;
        static IEnumerable<Step> _steps;
        public static IQueryable<CustomTask> Tasks
        {

            get
            {
                if (_tasks == null)
                {
                    _tasks = new List<CustomTask>()
            {
                new CustomTask(){
                   Id = 1,
                   Name="Task1",
                },
                new CustomTask()
                {
                    Name="Task2",
                    Id=2
                }
            };

                }

                return _tasks.AsQueryable();
            }
        }

        public static IQueryable<Step> Steps
        {
            get
            {
                if (_steps == null)
                {
                    _steps = new List<Step>()
                   {
                       new Step()
                       {
                           Id = 2,
                           Name="Step_1_1",
                           Owner="Marcel",
                           TaskId=1
                       },
                       new Step()
                       {
                           Id=3,
                           Name="Step_1_2",
                           Owner="Joe",
                           TaskId=1,

                       },
                        new Step()
                               { Id= 4,
                                 Name="Step_1_2_1",
                                 TaskId=1,
                                 ParentStepId=3,
                               },
                               new Step()
                               {
                                   Id=5,
                                   Name="Step_1_2_2",
                                   TaskId=1,
                                   ParentStepId=3
                               },
                        new Step()
                       {
                           Id=6,
                           Name="Step_1_3",
                           Owner="Joe",
                           TaskId=1,
                       },
                        new Step(){
                        Id=7,
                        Name="Step_1",
                        TaskId=2
                        }
            };
                }
                return _steps.AsQueryable();
            }
        }
    }
}