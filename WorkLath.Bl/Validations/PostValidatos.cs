using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using WorkLath.Bl.Dto;

namespace WorkLath.Bl.Validations
{
   public class PostValidator: AbstractValidator<PostDto>
    {
        public PostValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .WithMessage("Title is required");
        }
    }
}
