using Schedule.Data.Bases;
using Schedule.Data.Entities;
using Schedule.Data.UserSettings;

namespace Schedule.Data.ManyToMany
{
    public class UserCategory : ManyToManyBase
    {
        public User UserId { get; set; }
        public Category CategoryId { get; set; }
    }
}
