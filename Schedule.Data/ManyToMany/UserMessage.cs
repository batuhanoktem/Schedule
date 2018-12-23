using Schedule.Data.Bases;
using Schedule.Data.Entities;

namespace Schedule.Data.ManyToMany
{
    public class UserMessage : ManyToManyBase
    {
        public User UserId { get; set; }
        public Message MessageId { get; set; }
    }
}
