using Domain.Comman;

namespace Domain.Entities
{
    public class Department :BaseEntity
    {

        public string Name { get; set; }
        public int LocationId  { get; set; }
        public Location Location { get; set; }
    }
}
