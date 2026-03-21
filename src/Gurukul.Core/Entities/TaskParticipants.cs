using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Gurukul.Core.Entities
{
    public class TaskParticipants
    {
        public GUID Id { get; set; }
        public GUID TaskId { get; set; }
        public GUID UserId { get; set; }
        public string Status { get; set; }
        public DateTime AcceptedAt { get; set; }
        public Tasks Task { get; set; }
        public User User { get; set; }
    }
}