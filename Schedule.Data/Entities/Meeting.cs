using Schedule.Data.Bases;
using Schedule.Data.System;
using System;

namespace Schedule.Data.Entities
{
    public class Meeting : Base
    {
        public Group GroupId { get; set; }
        public Country CountryId { get; set; }
        public City CityId { get; set; }
        public DateTime MeetingDate { get; set; }
    }
}
