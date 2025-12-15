using BulkEmail.Producer.Models;
using BulkEmail.Producer.Models.DTO;

namespace BulkEmail.Producer.Services.Interfaces
{
    public interface ICampaignService
    {
        Task ProcessCampaignAsync(CreateCampaignRequest request);
    }
}
