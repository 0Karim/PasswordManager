using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Application.Logins.Commands.CreateNewLogin
{
    public class CreateNewLoginValidator : AbstractValidator<CreateNewLoginCommand>
    {
        public CreateNewLoginValidator()
        {
            RuleFor(v => v.UserName)
                .NotEmpty().WithMessage("Username is required.")
                .MaximumLength(100).WithMessage("Title must not exceed 100 characters.");

            RuleFor(v => v.Password)
                .NotEmpty().WithMessage("Password is required.");
        }
    }
}
