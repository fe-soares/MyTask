using Dev.Business.Models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dev.Business.Models
{
    public class Task: Entity
    {
        public string Title { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime StratDate { get; set; }
        public DateTime EndDate { get; set; }
        public TaskStatus Status { get; set; }
        public IEnumerable<TaskContext> TaskContext { get; set; }
    }
}
