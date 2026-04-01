namespace Gurukul.Core.DTOs.Groups
{
    public class CreateGroupRequest
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        /// <summary>"public" or "private"</summary>
        public string? Privacy { get; set; }
    }
}
