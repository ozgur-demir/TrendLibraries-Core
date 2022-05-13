using FluentValidation;
using FluentValidationApp.Web.Models;

namespace FluentValidationApp.Web.FluentValidators
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public string NotEmptyMsg = "{PropertyName} can not be empty";
        public CustomerValidator()
        {
          
        RuleFor(x => x.Name).NotEmpty().WithMessage(NotEmptyMsg);
            RuleFor(x => x.Email).NotEmpty().WithMessage(NotEmptyMsg).EmailAddress().WithMessage("Email is not correct");
            RuleFor(x => x.Age).NotEmpty().WithMessage(NotEmptyMsg).InclusiveBetween(18, 60).WithMessage("Age must between 18-60");

            RuleFor(x => x.BirthDay).NotEmpty().WithMessage(NotEmptyMsg).Must(x =>
            {
                return DateTime.Now.AddYears(-18) >= x;
            }).WithMessage("Your age must be grater than 18");
            RuleFor(x => x.Gender).IsInEnum().WithMessage("{PropertyName} field must 1 for male, 2 for female");
            
            RuleForEach(x => x.Addresses).SetValidator(new AddressValidator());


        }
    }
}
