using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Gurukul.Core.Entities
{
    public class Friendships
    {
        public GUID Id { get; set; }
        public GUID RequesterId { get; set; }
        public GUID ReceiverId { get; set; }
        public string Status { get; set; } 
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public User Requester {get; set; }
        public User Receiver {get; set; }
    }
}