namespace Gurukul.Core.DTOs.Groups
{
    public class GroupResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? Privacy { get; set; }
        public Guid CreatorId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
