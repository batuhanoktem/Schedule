using Schedule.Data.Bases;
using Schedule.Data.Entities;

namespace Schedule.Data.ManyToMany
{
    public class UserNotification : ManyToManyBase
    {
        public User UserId { get; set; }
        public Notification NotificationId { get; set; }
    }
}
