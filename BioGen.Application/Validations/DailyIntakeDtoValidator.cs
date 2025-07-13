using BioGen.Application.DTO;
using FluentValidation;

namespace BioGen.Application.Validations
{
    public class DailyIntakeDtoValidator:AbstractValidator<DailyIntakeDto>
    {
        public DailyIntakeDtoValidator()
        {
            RuleFor(x => x.CurrentIntake).NotEmpty();
        }
    }
}