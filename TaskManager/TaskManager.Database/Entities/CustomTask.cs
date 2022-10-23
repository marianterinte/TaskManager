using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Database.Entities
{
    public class CustomTask
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public IEnumerable<Step> Steps { get; set; }
    }
}
