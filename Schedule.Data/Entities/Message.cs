using Schedule.Data.Bases;
using System;

namespace Schedule.Data.Entities
{
    public class Message : Base
    {
        public User SendUserId { get; set; }
        public User ReceivedUserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime SendDate { get; set; }
        public bool IsRead { get; set; }
    }
}
