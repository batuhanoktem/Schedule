﻿using Schedule.Data.Bases;

namespace Schedule.Data.System
{
    public class City : SystemBase
    {
        public string Name { get; set; }
        public Country CountryId { get; set; }
    }
}