using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dev.Business.Models.Validations
{
    public class TaskValidation: AbstractValidator<Task>
    {
        public TaskValidation()
        {
            RuleFor(t => t.Title).NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(t => t.TaskContext).NotEmpty().WithMessage("{PropertyName} precisa ter mais de um ou mais registros");
        }
    }
}
