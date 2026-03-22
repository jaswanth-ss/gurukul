using System;

namespace Gurukul.Core.Entities
{
    public class TaskParticipants
    {
        public Guid Id { get; set; }
        public Guid TaskId { get; set; }
        public Guid UserId { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime AcceptedAt { get; set; }
        public Tasks Task { get; set; } = null!;
        public User User { get; set; } = null!;
    }
}
