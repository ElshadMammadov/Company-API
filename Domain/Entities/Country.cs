using Domain.Comman;

namespace Domain.Entities
{
    public class Country : BaseEntity
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int Population { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }
        public List<City> Cities { get; set; }
    }
}
