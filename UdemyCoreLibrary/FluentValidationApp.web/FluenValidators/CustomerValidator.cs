using FluentValidation;
using FluentValidationApp.web.Models;

namespace FluentValidationApp.web.FluenValidators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name)
    .NotEmpty()
    .WithMessage("Name field cannot be empty.");

            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("Email field cannot be empty.")
                .EmailAddress()
                .WithMessage("Please enter a valid email address.");

            RuleFor(x => x.Age)
                .NotEmpty()
                .WithMessage("Age field cannot be empty.")
                .InclusiveBetween(18, 60)
                .WithMessage("Age must be between 18 and 60.");

        }


    }
}
