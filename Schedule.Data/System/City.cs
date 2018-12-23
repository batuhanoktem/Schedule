using Schedule.Data.Bases;

namespace Schedule.Data.System
{
    public class City : SystemBase
    {
        public string Name { get; set; }

        #region Country
        public long CountryId { get; set; }
        public Country Country { get; set; } 
        #endregion
    }
}