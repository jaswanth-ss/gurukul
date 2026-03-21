using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Gurukul.Core.Entities
{
    public class TaskProgress
    {
        public GUID Id { get; set; }
        public GUID TaskId { get; set; }
        public GUID UserId { get; set; }
        public string ProgressStatus { get; set; }
        public string ProgressNotes { get; set; }
        public float ProgressPercentage { get; set; }
        public string UpdatedAt { get; set; }
        public Tasks Task { get; set; }
        public User User { get; set; }
    }
}