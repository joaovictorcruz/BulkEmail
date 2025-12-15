using BulkEmail.Producer.Models.DTO;
using BulkEmail.Producer.Services;
using BulkEmail.Producer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BulkEmail.Producer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignController : ControllerBase
    {
        private readonly ICampaignService _campaignService;
        public CampaignController(ICampaignService campaignService)
        {
            _campaignService = campaignService;  
        }

        [HttpPost]
        public async  Task <IActionResult> CreateCampaign([FromBody] CreateCampaignRequest request)
        {
            await _campaignService.ProcessCampaignAsync(request);   
            return Accepted();
        }
    }
}
