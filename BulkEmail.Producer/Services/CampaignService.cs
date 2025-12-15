using BulkEmail.Producer.Messaging;
using BulkEmail.Producer.Models;
using BulkEmail.Producer.Models.DTO;
using BulkEmail.Producer.Services.Interfaces;

namespace BulkEmail.Producer.Services
{
    public class CampaignService : ICampaignService
    {
        private readonly RabbitMqPublisher _publisher;

        public CampaignService(RabbitMqPublisher publisher)
        {
            _publisher = publisher;
        }

        public async Task ProcessCampaignAsync(CreateCampaignRequest request)
        {
            var campaignId = Guid.NewGuid();

            foreach (var email in request.Emails)
            {
                var emailEvent = new EmailEvent
                {
                    CampaignId = campaignId,
                    Email = email,
                    Subject = request.Subject,
                    Body = request.Body,
                    CreatedAt = DateTime.UtcNow
                };

                await _publisher.PublishAsync(emailEvent);
            }
        }
    }
}
