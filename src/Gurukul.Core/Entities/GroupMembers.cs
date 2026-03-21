using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Gurukul.Core.Entities
{
    public class GroupMembers
    {
        public GUID Id { get; set; }
        public GUID GroupId { get; set; }
        public GUID UserId { get; set; }
        public string Role { get; set; } 
        public DateTime JoinedAt { get; set; }
        public Group Group { get; set; }
        public User User { get; set; }
    }
}