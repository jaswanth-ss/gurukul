using System;

namespace Gurukul.Core.Entities
{
    public class UserProfiles
    {
        public Guid UserId { get; set; }
        public string? Bio { get; set; }
        public string? LearningInterest { get; set; }
        public string? LearningLevel { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public string? ProgressVisibility { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? AvatarUrl { get; set; }
        public User User { get; set; } = null!;
    }
}
