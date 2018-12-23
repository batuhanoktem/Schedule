using Schedule.Data.Bases;
using Schedule.Data.Entities;

namespace Schedule.Data.ManyToMany
{
    public class UserMeeting : ManyToManyBase
    {
        public User UserId { get; set; }
        public Meeting MeetingId { get; set; }
    }
}
