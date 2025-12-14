using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BulkEmail.Producer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignController : ControllerBase
    {
        public CampaignController()
        {
        }

        [HttpPost]
        public IActionResult CreateCampaign()
        {
            return Accepted();
        }
    }
}
