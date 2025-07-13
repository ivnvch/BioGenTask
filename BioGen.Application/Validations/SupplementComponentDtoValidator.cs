using BioGen.Application.DTO;
using FluentValidation;

namespace BioGen.Application.Validations
{
    public class SupplementComponentDtoValidator : AbstractValidator<SupplementComponentDto>
    {
        public SupplementComponentDtoValidator()
        {
            RuleFor(x => x.Amount).GreaterThan(0);
        }
    }
}