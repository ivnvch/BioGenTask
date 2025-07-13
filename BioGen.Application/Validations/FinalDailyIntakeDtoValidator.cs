using BioGen.Application.DTO;
using FluentValidation;

namespace BioGen.Application.Validations
{
    public class FinalDailyIntakeDtoValidator: AbstractValidator<FinalDailyIntakeDto>
    {
        public FinalDailyIntakeDtoValidator()
        {
            RuleFor(x => x.FromFood).GreaterThanOrEqualTo(0);
            RuleFor(x => x.FromSupplement).GreaterThanOrEqualTo(0);
        }
    }
}