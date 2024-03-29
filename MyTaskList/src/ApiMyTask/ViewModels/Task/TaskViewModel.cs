﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMyTask.ViewModels.Task
{
    public class TaskViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Title { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime StratDate { get; set; }
        public DateTime EndDate { get; set; }
        public TaskStatus Status { get; set; }
        public IEnumerable<TaskContextViewModel> TaskContext { get; set; }
    }
}
