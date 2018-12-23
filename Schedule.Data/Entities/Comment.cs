using Schedule.Data.Bases;

namespace Schedule.Data.Entities
{
    public class Comment : Base
    {
        public User UserId { get; set; }
        public Meeting MeetingId { get; set; }
    }
}
