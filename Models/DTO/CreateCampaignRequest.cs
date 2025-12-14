namespace BulkEmail.Producer.Models.DTO
{
    public class CreateCampaignRequest
    {
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public List<string> Emails { get; set; } = new();
    }
}
