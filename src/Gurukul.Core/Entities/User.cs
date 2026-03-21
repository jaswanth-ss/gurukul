using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Gurukul.Core.Entities
{
    public class User
    {
        public GUID Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public UserProfiles Profile { get; set; }
        public ICollection<Friendships> SentFriendships { get; set; }
        public ICollection<Friendships> ReceivedFriendships { get; set; }
        public ICollection<Mentor> Mentors { get; set; }
        public ICollection<Mentor> MonitoredBy { get; set; }
        public ICollection<GroupMembers> GroupMemberships { get; set; }
        public ICollection<TaskParticipants> TaskParticipations { get; set; }
        public ICollection<Tasks> CreatedTasks { get; set; }
    }
}