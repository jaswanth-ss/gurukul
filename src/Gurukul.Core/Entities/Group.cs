using System;
using System.Collections.Generic;

namespace Gurukul.Core.Entities
{
    public class Group
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public Guid CreatorId { get; set; }
        public string? Privacy { get; set; }
        public DateTime CreatedAt { get; set; }
        public User Creator { get; set; } = null!;
        public ICollection<GroupMembers> Members { get; set; } = new List<GroupMembers>();
        public ICollection<Tasks> Tasks { get; set; } = new List<Tasks>();
    }
}
