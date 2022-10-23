using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Database.Entities
{
    public class Step
    {
        public int Id { get; set; }

        public int ParentStepId { get; set; }

        public string Name { get; set; }

        public string Owner { get; set; }

        public IEnumerable<Step> Children { get; set; }

        public int TaskId { get; set; }
    }
}
