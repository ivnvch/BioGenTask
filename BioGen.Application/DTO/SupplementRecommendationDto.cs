using System.Collections.Generic;

namespace BioGen.Application.DTO
{
    public record SupplementRecommendationDto(string Name, string Description, List<SupplementComponentDto> SupplementComponents);
}