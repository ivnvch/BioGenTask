using BioGen.Application.DTO;
using FluentValidation;

namespace BioGen.Application.Validations
{
    public class SupplementRecommendationDtoValidator: AbstractValidator<SupplementRecommendationDto>
    {
        public SupplementRecommendationDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleForEach(x => x.SupplementComponents).SetValidator(new SupplementComponentDtoValidator());
        }
    }
}