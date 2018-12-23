using Schedule.Data.Bases;

namespace Schedule.Data.Entities
{
    public class Group : Base
    {
        public string Name { get; set; }
        public int UserCount { get; set; }
    }
}
