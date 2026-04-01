namespace Gurukul.Core.DTOs.Groups
{
    public class UpdateGroupRequest
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? Privacy { get; set; }
    }
}
