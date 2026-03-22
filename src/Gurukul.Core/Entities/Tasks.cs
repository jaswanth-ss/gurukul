using System;
using System.Collections.Generic;

namespace Gurukul.Core.Entities
{
    public class Tasks
    {
        public Guid Id { get; set; }
        public Guid CreatorId { get; set; }
        public Guid? GroupId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime DueDate { get; set; }
        public string? TaskType { get; set; }
        public bool IsGroupTask { get; set; }
        public DateTime CreatedAt { get; set; }
        public User Creator { get; set; } = null!;
        public Group? Group { get; set; }
        public ICollection<TaskParticipants> Participants { get; set; } = new List<TaskParticipants>();
        public ICollection<TaskProgress> Progress { get; set; } = new List<TaskProgress>();
    }
}
