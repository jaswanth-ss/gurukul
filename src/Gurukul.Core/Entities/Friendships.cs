using System;

namespace Gurukul.Core.Entities
{
    public class Friendships
    {
        public Guid Id { get; set; }
        public Guid RequesterId { get; set; }
        public Guid ReceiverId { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public User Requester { get; set; } = null!;
        public User Receiver { get; set; } = null!;
    }
}
