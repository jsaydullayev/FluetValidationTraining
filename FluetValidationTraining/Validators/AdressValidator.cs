using FluentValidation;
using FluetValidationTraining.Entity;

namespace FluetValidationTraining.Validators
{
    public class AdressValidator : AbstractValidator<Adress>
    {
        public AdressValidator()
        {
            RuleFor(address => address.City).NotNull().WithMessage("City cannot is empty");
            RuleFor(a => a.Country).NotNull()
            .Must(c => c == "Uzbekistan");
            RuleFor(a => a.ZipCode)
                .LessThan(110000).GreaterThan(100000);

            When(a => a.Street is not null, () =>
            {
                RuleFor(a => a.Street).MinimumLength(5)
                    .MaximumLength(32);
            });
        }
    }
}
