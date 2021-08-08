using Dev.Business.Models.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dev.Business.Models
{
    public class TaskContext: Entity
    {
        public Guid TaskId { get; set; }

        public Task Task { get; set; }
        public string TitleStep { get; set; }

        public string ContextStep { get; set; }

        public StatusStep Status { get; set; }
    }
}
