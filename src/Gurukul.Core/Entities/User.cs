using System;
using System.Collections.Generic;

namespace Gurukul.Core.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public UserProfiles? Profile { get; set; }
        public ICollection<Friendships> SentFriendships { get; set; } = new List<Friendships>();
        public ICollection<Friendships> ReceivedFriendships { get; set; } = new List<Friendships>();
        public ICollection<Mentor> Mentors { get; set; } = new List<Mentor>();
        public ICollection<Mentor> MonitoredBy { get; set; } = new List<Mentor>();
        public ICollection<GroupMembers> GroupMemberships { get; set; } = new List<GroupMembers>();
        public ICollection<TaskParticipants> TaskParticipations { get; set; } = new List<TaskParticipants>();
        public ICollection<Tasks> CreatedTasks { get; set; } = new List<Tasks>();
    }
}
