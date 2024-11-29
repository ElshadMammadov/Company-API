using Domain.Comman;

namespace Domain.Entities
{
    public class Department : BaseEntity
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int locationId  { get; set; }
        public Location location { get; set; }
    }
}
