using FluentValidation;
using FluetValidationTraining.Models;

namespace FluetValidationTraining.Validators
{
    public class RegisterValidator : AbstractValidator<CreateUserModel>
    {
        public RegisterValidator()
        {
            RuleFor(u => u.FirstName)
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(16);
            RuleFor(u => u.LastName)
                .NotNull()
                .MinimumLength(2)
                .MaximumLength(16);
            RuleFor(u => u.UserName)
                .NotNull()
                .MinimumLength(5)
                .MaximumLength(32);
            RuleFor(u => u.Password)
                .NotNull()
                .MinimumLength(8)
                .MaximumLength(32);
            RuleFor(u => u.Gender)
                .NotNull();
            When(u => u.Age is not null, () =>
            {
                RuleFor(u => Convert.ToInt32(u.Age))
                .Must(a => a < 120 && 6 < a);
            });
            When(u => u.UserAdress is not null, () =>
            {
                RuleFor(u => u.UserAdress)
                .SetValidator(new AdressValidator()!);
            });
        }
    }
}