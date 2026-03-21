using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Gurukul.Core.Entities
{
    public class Tasks
    {
        public GUID Id { get; set; }
        public GUID CreatorId { get; set; }
        public GUID GroupId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string TaskType { get; set; }
        public string IsGroupTask { get; set; }
        public DateTime CreatedAt { get; set; }
        public User Creator { get; set; }
        public Group Group { get; set; }
        public ICollection<TaskParticipants> Participants { get; set; }
        public ICollection<TaskProgress> Progress { get; set; }
    }
}