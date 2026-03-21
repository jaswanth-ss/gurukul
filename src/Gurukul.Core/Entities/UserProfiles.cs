using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Gurukul.Core.Entities
{
    public class UserProfiles
    {
        public GUID UserId { get; set; }
        public string Bio { get; set; }
        public string LearningInterest { get; set; }
        public string LearningLevel { get; set; }
        public string DateOfBirth { get; set; }
        public string ProgressVisibility { get; set; }
        public string UpdatedAt { get; set; }
        public string AvatarUrl { get; set; }
        public User user { get; set; }
    }
}