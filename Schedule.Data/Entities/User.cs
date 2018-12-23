using Schedule.Data.Bases;
using Schedule.Data.System;

namespace Schedule.Data.Entities
{
    public class User : Base
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        #region City
        public long CityId { get; set; }
        public City City { get; set; } 
        #endregion

        #region Country
        public long CountryId { get; set; }
        public Country Country { get; set; } 
        #endregion

        #region Language
        public long LanguageId { get; set; }
        public Language Language { get; set; } 
        #endregion

        public string Bio { get; set; }
        public bool Gender { get; set; }
    }
}
