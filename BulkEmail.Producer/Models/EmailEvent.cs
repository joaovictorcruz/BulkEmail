namespace BulkEmail.Producer.Models
{
    public class EmailEvent
    {
        public Guid CampaignId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}
