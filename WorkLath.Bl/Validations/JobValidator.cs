using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using WorkLath.Bl.Dto;

namespace WorkLath.Bl.Validations
{
    public class JobValidator : AbstractValidator<JobDto>
    {
        public JobValidator()
        {
            RuleFor(x=> x.Name)
                .NotEmpty()
                .WithMessage("Job name is required");
        }
    }
}
