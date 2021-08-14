using Dev.Business.Models.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMyTask.ViewModels.Task
{
    public class TaskContextViewModel
    {
        [Key]
        public Guid Id { get; set; }
        public Guid TaskId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string TitleStep { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string ContextStep { get; set; }

        public string ShortDescriptionStep { get; set; }

        public StatusStep Status { get; set; }
    }
}
