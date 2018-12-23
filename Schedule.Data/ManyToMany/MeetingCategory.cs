using Schedule.Data.Bases;
using Schedule.Data.Entities;
using Schedule.Data.UserSettings;

namespace Schedule.Data.ManyToMany
{
    public class MeetingCategory : ManyToManyBase
    {
        public Meeting MeetingId { get; set; }
        public Category CategoryId { get; set; }
    }
}
