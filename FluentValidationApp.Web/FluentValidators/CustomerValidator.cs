using FluentValidation;
using FluentValidationApp.Web.Models;

namespace FluentValidationApp.Web.FluentValidators
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name can not be empty");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email can not be empty").EmailAddress().WithMessage("Email is not correct");
            RuleFor(x => x.Age).NotEmpty().WithMessage("Age can not be empty").InclusiveBetween(18, 60).WithMessage("Age must between 18-60");
        }
    }
}
