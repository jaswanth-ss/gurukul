using System;

namespace Gurukul.Core.Entities
{
    public class GroupMembers
    {
        public Guid Id { get; set; }
        public Guid GroupId { get; set; }
        public Guid UserId { get; set; }
        public string Role { get; set; } = string.Empty;
        public DateTime JoinedAt { get; set; }
        public Group Group { get; set; } = null!;
        public User User { get; set; } = null!;
    }
}
