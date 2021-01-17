using FluentValidation;
using Market_MVCWebUI.Models;

namespace Market_MVCWebUI.ValidationRules.FluentValidation
{
    public class ShippingDetailValidator:AbstractValidator<ShippingDetail>
    {
        public ShippingDetailValidator()
        {
            RuleFor(s => s.FirstName).NotEmpty().WithMessage("First name is required");
            RuleFor(s => s.Address).NotEmpty();
            RuleFor(s => s.LastName).NotEmpty();
            RuleFor(s => s.Age).NotEmpty();

           // RuleFor(s => s.FirstName).Must(StartWithA);


        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
