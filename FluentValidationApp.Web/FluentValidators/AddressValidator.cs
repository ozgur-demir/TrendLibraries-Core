using FluentValidation;
using FluentValidationApp.Web.Models;

namespace FluentValidationApp.Web.FluentValidators
{
    public class AddressValidator:AbstractValidator<Address>
    {
        public string NotEmptyMsg = "{PropertyName} can not be empty";
        public AddressValidator()
        {
            RuleFor(x => x.Content).NotEmpty().WithMessage(NotEmptyMsg);
            RuleFor(x => x.City).NotEmpty().WithMessage(NotEmptyMsg);
            RuleFor(x => x.PostCode).NotEmpty().WithMessage(NotEmptyMsg).MaximumLength(5).WithMessage("{PropertyName} field can not be longer than {MaxLenght} ");
        }
    }
}
