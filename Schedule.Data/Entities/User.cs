using Schedule.Data.Bases;
using Schedule.Data.System;

namespace Schedule.Data.Entities
{
    public class User : Base
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public City CityId { get; set; }
        public Country CountryId { get; set; }
        public Language LanguageId { get; set; }
        public string Bio { get; set; }
        public bool Gender { get; set; }
    }
}
