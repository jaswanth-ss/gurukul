using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Gurukul.Core.Entities
{
    public class Mentor
    {
        public GUID Id { get; set; }
        public GUID MonitorId { get; set; }
        public GUID StudentId { get; set; }
        public string Relation { get; set; }
        public string Status { get; set; }
        public string RequestedAt { get; set; }
        public string UpdatedAt { get; set; }
        public User Monitor { get; set; }
        public User Student { get; set; }
    }
}