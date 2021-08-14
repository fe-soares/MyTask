using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dev.Business.Models.Validations
{
    public class TaskContextValidation : AbstractValidator<TaskContext>
    {
        public TaskContextValidation()
        {
            RuleFor(c => c.TitleStep)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 200).WithMessage("O campo { PropertyName} precisa ter entre { MinLength} e { MaxLength} caracteres");

            RuleFor(c => c.ContextStep)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 200).WithMessage("O campo { PropertyName} precisa ter entre { MinLength} e { MaxLength} caracteres");
        }
    }
}
