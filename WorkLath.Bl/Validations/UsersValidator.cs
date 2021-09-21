using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using WorkLath.Bl.Dto;

namespace WorkLath.Bl.Validations
{
    public class UsersValidator: AbstractValidator<UsersDto>
    {
        public UsersValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Name is Required");
        }
    }
}
