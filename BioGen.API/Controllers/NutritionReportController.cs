using System.Threading.Tasks;
using BioGen.Application.Abstractions.Services;
using BioGen.Application.DTO;
using Microsoft.AspNetCore.Mvc;

namespace BioGen.API.Controllers
{
    [ApiController]
    [Route("api/nutritionreport")]
    public class NutritionReportController : ControllerBase
    {
        private readonly INutritionReportService _nutritionReportService;

        public NutritionReportController( INutritionReportService nutritionReportService)
        {
            _nutritionReportService = nutritionReportService;
        }
        
        [HttpGet]
        public async Task<ActionResult> GetLatestReport()
        {
            var response = await _nutritionReportService.GetLatestAsync();
            if (response == null)
                return NotFound();
            
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult> SaveReport(NutritionReportDto nutrientReportDto)
        {
            var response = await _nutritionReportService.CreateReportAsync(nutrientReportDto);
            
            return Ok(response);
        }
    }
}