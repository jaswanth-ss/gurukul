using System;

namespace Gurukul.Core.Entities
{
    public class Mentor
    {
        public Guid Id { get; set; }
        public Guid MonitorId { get; set; }
        public Guid StudentId { get; set; }
        public string? Relation { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime RequestedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public User Monitor { get; set; } = null!;
        public User Student { get; set; } = null!;
    }
}
