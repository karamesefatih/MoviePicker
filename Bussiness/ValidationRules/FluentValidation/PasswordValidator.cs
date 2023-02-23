using Core.Dtos;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class PasswordValidator : AbstractValidator<UserForRegisterDto>
    {
        public PasswordValidator() {
            RuleFor(p => p.Password).NotEmpty().WithMessage("Pasword can't be empty");
            RuleFor(p => p.Password).Length(8,16).WithMessage("Pasword must be beetween 8 letters and 16 letters");
     
        
        }
    }
}
