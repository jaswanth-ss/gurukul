using System;

namespace Gurukul.Core.Entities
{
    public class TaskProgress
    {
        public Guid Id { get; set; }
        public Guid TaskId { get; set; }
        public Guid UserId { get; set; }
        public string? ProgressStatus { get; set; }
        public string? ProgressNotes { get; set; }
        public float ProgressPercentage { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Tasks Task { get; set; } = null!;
        public User User { get; set; } = null!;
    }
}
