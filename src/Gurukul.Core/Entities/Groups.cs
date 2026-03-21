using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Gurukul.Core.Entities
{
    public class Groups
    {
        public GUID Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public GUID CreatorId { get; set; }
        public string Privacy { get; set; } 
        public DateTime CreatedAt { get; set; }
        public User Creator { get; set; }
        public ICollection<GroupMembers> Members { get; set; }
        public ICollection<Tasks> Tasks { get; set; }

    }
}