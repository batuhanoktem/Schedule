using Schedule.Data.Bases;
using Schedule.Data.Entities;

namespace Schedule.Data.ManyToMany
{
    public class UserGroup : ManyToManyBase
    {
        public User UserId { get; set; }
        public Group GroupId { get; set; }
    }
}
